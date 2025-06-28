CREATE DATABASE JLaboratoriesDB;

USE JLaboratoriesDB;

-- 1) Tabla de usuarios (login)
CREATE TABLE Users (
    UserID        INT           IDENTITY(1,1) PRIMARY KEY,
    Username      NVARCHAR(50)  NOT NULL UNIQUE,
    PasswordHash  NVARCHAR(255) NOT NULL,
    FullName      NVARCHAR(100) NULL,
    CreatedAt     DATETIME      NOT NULL DEFAULT GETDATE()
);
GO

-- 2) Tabla de clientes
CREATE TABLE Clients (
    ClientID      INT           IDENTITY(1,1) PRIMARY KEY,
    FirstName     NVARCHAR(100) NOT NULL,
    LastName      NVARCHAR(100) NOT NULL,
    PhoneNumber   NVARCHAR(20)  NULL,
    Address       NVARCHAR(200) NULL,
    CreatedAt     DATETIME      NOT NULL DEFAULT GETDATE()
);
GO

-- 3) Tabla de PCs
CREATE TABLE PCs (
    PCID          INT           IDENTITY(1,1) PRIMARY KEY,
    ClientID      INT           NOT NULL,
    Model         NVARCHAR(100) NOT NULL,
    SerialNumber  NVARCHAR(100) NULL,
    CreatedAt     DATETIME      NOT NULL DEFAULT GETDATE(),
    CONSTRAINT FK_PCs_Clients FOREIGN KEY (ClientID)
        REFERENCES Clients(ClientID)
        ON DELETE CASCADE
);

-- 4) Tabla de órdenes (sin cascada sobre PCID)
CREATE TABLE Orders (
    OrderID       INT           IDENTITY(1,1) PRIMARY KEY,
    ClientID      INT           NOT NULL,
    PCID          INT           NULL,
    Notes         NVARCHAR(1000) NULL,
    IsUrgent      BIT           NOT NULL DEFAULT 0,
    Status        NVARCHAR(20)  NOT NULL
                   CONSTRAINT CHK_Orders_Status
                     CHECK (Status IN ('Pending','Urgent','Completed')),
    CreatedAt     DATETIME      NOT NULL DEFAULT GETDATE(),
    CompletedAt   DATETIME      NULL,
    CONSTRAINT FK_Orders_Clients FOREIGN KEY (ClientID)
        REFERENCES Clients(ClientID)
        ON DELETE CASCADE,
    -- Eliminamos ON DELETE SET NULL para evitar múltiples paths de cascada
    CONSTRAINT FK_Orders_PCs FOREIGN KEY (PCID)
        REFERENCES PCs(PCID)
        -- acción por defecto: NO ACTION (o podrías omitir esta línea completamente)
        ON DELETE NO ACTION
);
GO

-- 4) Tabla de tickets (uno por orden)
CREATE TABLE Tickets (
    TicketID      INT           IDENTITY(1,1) PRIMARY KEY,
    OrderID       INT           NOT NULL UNIQUE,
    TicketNumber  NVARCHAR(20)  NOT NULL UNIQUE,
    CreatedAt     DATETIME      NOT NULL DEFAULT GETDATE(),
    CONSTRAINT FK_Tickets_Orders FOREIGN KEY (OrderID)
        REFERENCES Orders(OrderID)
        ON DELETE CASCADE
);
GO
----------------------------------------------------------------------------------
-- Índices para optimizar consultas

-- Si ya existe, lo borramos
IF EXISTS (
    SELECT 1 
    FROM sys.indexes 
    WHERE name = 'IX_Orders_CreatedAt' 
      AND object_id = OBJECT_ID('Orders')
)
    DROP INDEX IX_Orders_CreatedAt ON Orders;
GO

CREATE INDEX IX_Orders_CreatedAt 
    ON Orders(CreatedAt DESC);
GO

IF EXISTS (
    SELECT 1 
    FROM sys.indexes 
    WHERE name = 'IX_Orders_Status' 
      AND object_id = OBJECT_ID('Orders')
)
    DROP INDEX IX_Orders_Status ON Orders;
GO

CREATE INDEX IX_Orders_Status    
    ON Orders(Status);
GO
---------------------------------------------------------------------------------
-- Vistas para simplificar consultas

-- Vista que muestra por cada cliente su número de órdenes y la cantidad de PCs
IF OBJECT_ID('dbo.vw_ClientPCOrders','V') IS NOT NULL
    DROP VIEW dbo.vw_ClientPCOrders;
GO

CREATE VIEW dbo.vw_ClientPCOrders
AS
SELECT
    c.ClientID,
    c.FirstName + ' ' + c.LastName AS ClientName,
    COUNT(o.OrderID)        AS TotalOrders,
    COUNT(DISTINCT p.PCID)  AS TotalDistinctPCs
FROM dbo.Clients c
INNER JOIN dbo.Orders o 
    ON c.ClientID = o.ClientID
INNER JOIN dbo.PCs p
    ON o.PCID = p.PCID
GROUP BY
    c.ClientID,
    c.FirstName,
    c.LastName;
GO


-- Vista de órdenes recientes (una fila por orden con datos de cliente y PC)
IF OBJECT_ID('dbo.vw_RecentOrders','V') IS NOT NULL
    DROP VIEW dbo.vw_RecentOrders;
GO
CREATE VIEW dbo.vw_RecentOrders
AS
SELECT
    c.FirstName + ' ' + c.LastName AS Client,
    p.Model                       AS PCModel,
    o.Notes,
    o.Status
FROM dbo.Orders o
JOIN dbo.Clients c ON c.ClientID = o.ClientID
JOIN dbo.PCs     p ON p.PCID     = o.PCID;
GO

-- Vista de resumen (conteos para las Summary Cards)
IF OBJECT_ID('dbo.vw_OrderSummary','V') IS NOT NULL
    DROP VIEW dbo.vw_OrderSummary;
GO
CREATE VIEW dbo.vw_OrderSummary
AS
SELECT
    SUM(CASE WHEN o.Status = 'Pending'   THEN 1 ELSE 0 END) AS PendingCount,
    SUM(CASE WHEN o.Status = 'Urgent'    THEN 1 ELSE 0 END) AS UrgentCount,
    SUM(CASE WHEN o.Status = 'Completed' THEN 1 ELSE 0 END) AS CompletedCount
FROM dbo.Orders o;
GO

--------------------------------------------------------------------------------
-- Trigger (para que al actualizar una orden a Completed ponga automáticamente la fecha en CompletedAt)
CREATE TRIGGER TR_Orders_SetCompletedAt
ON dbo.Orders
AFTER UPDATE
AS
BEGIN
    SET NOCOUNT ON;

    -- Solo nos interesa cuando cambió la columna Status
    IF UPDATE(Status)
    BEGIN
        UPDATE o
        SET CompletedAt = GETDATE()
        FROM dbo.Orders AS o
        INNER JOIN inserted AS i ON o.OrderID = i.OrderID
        INNER JOIN deleted  AS d ON d.OrderID = i.OrderID
        WHERE 
            i.Status = 'Completed'
            AND (d.Status <> 'Completed' OR d.Status IS NULL);
    END
END;
GO

------------------------------------------------------------------------------------------------
-----Procedimientos almacenado
/*--- Listar todos los clientes ---*/
CREATE OR ALTER PROCEDURE dbo.sp_ListClients
AS
BEGIN
    -- Evita que se devuelva un contador de filas afectadas adicional
    SET NOCOUNT ON;

    -- Selecciona los campos esenciales de la tabla Clients
    -- Ordenados por Apellido y luego Nombre para facilitar la lectura
    SELECT 
        ClientID, 
        FirstName, 
        LastName, 
        PhoneNumber, 
        Address, 
        CreatedAt
    FROM Clients
    ORDER BY LastName, FirstName;
END
GO


/*--- Agregar un nuevo cliente ---*/
CREATE OR ALTER PROCEDURE dbo.sp_AddClient
    @FirstName   NVARCHAR(100),    -- Nombre del cliente (requerido)
    @LastName    NVARCHAR(100),    -- Apellido del cliente (requerido)
    @PhoneNumber NVARCHAR(20)  = NULL,    -- Teléfono (opcional)
    @Address     NVARCHAR(200) = NULL     -- Dirección (opcional)
AS
BEGIN
    SET NOCOUNT ON;

    -- Inserta un nuevo registro en Clients usando los parámetros recibidos
    INSERT INTO Clients (FirstName, LastName, PhoneNumber, Address)
    VALUES (@FirstName, @LastName, @PhoneNumber, @Address);

    -- Devuelve el ID recién generado para uso en la capa de negocio
    SELECT SCOPE_IDENTITY() AS NewClientID;
END
GO

select * from Clients


/*--- Actualizar datos de un cliente existente ---*/
CREATE OR ALTER PROCEDURE dbo.sp_UpdateClient
    @ClientID    INT,              -- ID del cliente a actualizar (requerido)
    @FirstName   NVARCHAR(100),    -- Nuevo nombre (requerido)
    @LastName    NVARCHAR(100),    -- Nuevo apellido (requerido)
    @PhoneNumber NVARCHAR(20)  = NULL,    -- Nuevo teléfono (opcional)
    @Address     NVARCHAR(200) = NULL     -- Nueva dirección (opcional)
AS
BEGIN
    SET NOCOUNT ON;

    -- Actualiza los campos correspondientes del cliente
    UPDATE Clients
    SET 
        FirstName   = @FirstName,
        LastName    = @LastName,
        PhoneNumber = @PhoneNumber,
        Address     = @Address
    WHERE ClientID = @ClientID;
END
GO

select * from Clients

/*--- Eliminar un cliente por ID ---*/
CREATE OR ALTER PROCEDURE dbo.sp_DeleteClient
    @ClientID INT     -- ID del cliente a eliminar (requerido)
AS
BEGIN
    SET NOCOUNT ON;

    -- Borra el cliente; las FK con ON DELETE CASCADE
    -- eliminan automáticamente PCs y Órdenes relacionadas
    DELETE FROM Clients 
    WHERE ClientID = @ClientID;
END
GO
select * from Clients

-- Ver views
SELECT * FROM dbo.vw_RecentOrders
SELECT * FROM dbo.vw_OrderSummary
SELECT * FROM dbo.vw_ClientPCOrders