using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JLaboratories.Entity;
using Microsoft.Data.SqlClient;

namespace JLaboratories.Data
{
    public class CD_Orders
    {
        public static List<Order> ListarTodos()
        {
            var lista = new List<Order>();
            using var cn = Connection.Get(); // Updated to use Connection.Get()
            using var cmd = new SqlCommand(@"
        SELECT OrderID, ClientID, PCID, Notes, IsUrgent, Status, CreatedAt, CompletedAt
          FROM Orders
         ORDER BY CreatedAt DESC", cn);
            cn.Open();
            using var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new Order
                {
                    OrderID = dr.GetInt32(0),
                    ClientID = dr.GetInt32(1),
                    PCID = dr.IsDBNull(2) ? null : dr.GetInt32(2),
                    Notes = dr.IsDBNull(3) ? string.Empty : dr.GetString(3),
                    IsUrgent = dr.GetBoolean(4),
                    Status = dr.GetString(5),
                    CreatedAt = dr.GetDateTime(6),
                    CompletedAt = dr.IsDBNull(7) ? (DateTime?)null : dr.GetDateTime(7)
                });
            }
            return lista;
        }

        public int Agregar(Order o)
        {
            using var cn = Connection.Get(); // Updated to use Connection.Get()
            using var cmd = new SqlCommand(@"
                INSERT INTO Orders (ClientID, PCID, Notes, IsUrgent, Status)
                OUTPUT INSERTED.OrderID
                VALUES (@cid, @pid, @nt, @urg, @st)", cn);
            cmd.Parameters.AddWithValue("@cid", o.ClientID);
            cmd.Parameters.AddWithValue("@pid", o.PCID.HasValue ? o.PCID.Value : DBNull.Value);
            cmd.Parameters.AddWithValue("@nt", (object)o.Notes ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@urg", o.IsUrgent);
            cmd.Parameters.AddWithValue("@st", o.Status);
            cn.Open();
            return (int)cmd.ExecuteScalar();
        }

        public void ActualizarStatus(int orderId, string status, bool isUrgent)
        {
            using var cn = Connection.Get(); // Updated to use Connection.Get()
            using var cmd = new SqlCommand(@"
                UPDATE Orders
                   SET Status   = @st,
                       IsUrgent = @urg
                 WHERE OrderID = @id", cn);
            cmd.Parameters.AddWithValue("@st", status);
            cmd.Parameters.AddWithValue("@urg", isUrgent);
            cmd.Parameters.AddWithValue("@id", orderId);
            cn.Open();
            cmd.ExecuteNonQuery();
        }

        public void Eliminar(int orderId)
        {
            using var cn = Connection.Get(); // Updated to use Connection.Get()
            using var cmd = new SqlCommand(
                "DELETE FROM Orders WHERE OrderID = @id", cn);
            cmd.Parameters.AddWithValue("@id", orderId);
            cn.Open();
            cmd.ExecuteNonQuery();
        }
        public List<RecentOrderSimpleDto> ListRecentSimple()
        {
            var list = new List<RecentOrderSimpleDto>();
            using var cn = Connection.Get();
            using var cmd = new SqlCommand(
                "SELECT Client, PCModel, Notes, Status FROM vw_RecentOrders",
                cn);
            cn.Open();
            using var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                list.Add(new RecentOrderSimpleDto
                {
                    Client = dr.GetString(0),
                    PCModel = dr.GetString(1),
                    Notes = dr.IsDBNull(2) ? null : dr.GetString(2),
                    Status = dr.GetString(3)
                });
            }
            return list;
        }

        public OrderSummaryDto GetSummary()
        {
            using var cn = Connection.Get();
            using var cmd = new SqlCommand("SELECT * FROM vw_OrderSummary", cn);
            cn.Open();
            using var dr = cmd.ExecuteReader(CommandBehavior.SingleRow);
            if (!dr.Read()) return new OrderSummaryDto();
            return new OrderSummaryDto
            {
                PendingCount = dr.IsDBNull(dr.GetOrdinal("PendingCount")) ? 0 : dr.GetInt32(dr.GetOrdinal("PendingCount")),
                UrgentCount = dr.IsDBNull(dr.GetOrdinal("UrgentCount")) ? 0 : dr.GetInt32(dr.GetOrdinal("UrgentCount")),
                CompletedCount = dr.IsDBNull(dr.GetOrdinal("CompletedCount")) ? 0 : dr.GetInt32(dr.GetOrdinal("CompletedCount"))
            };

        }

        public List<ClientPCOrdersDto> GetSummaryClients()
        {
            var lista = new List<ClientPCOrdersDto>();
            using var cn = Connection.Get();
            using var cmd = new SqlCommand(
                "SELECT ClientID, ClientName, TotalOrders, TotalDistinctPCs FROM dbo.vw_ClientPCOrders",
                cn
            );
            cn.Open();
            using var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new ClientPCOrdersDto
                {
                    ClientID = dr.GetInt32(dr.GetOrdinal("ClientID")),
                    ClientName = dr.GetString(dr.GetOrdinal("ClientName")),
                    TotalOrders = dr.IsDBNull(dr.GetOrdinal("TotalOrders"))
                                         ? 0
                                         : dr.GetInt32(dr.GetOrdinal("TotalOrders")),
                    TotalDistinctPCs = dr.IsDBNull(dr.GetOrdinal("TotalDistinctPCs"))
                                         ? 0
                                         : dr.GetInt32(dr.GetOrdinal("TotalDistinctPCs"))
                });
            }
            return lista;
        }

    }
}
