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
    internal class Orders_Trigger
    {

            /// <summary>
            /// Marca una orden como “Completed”, lo que disparará el trigger
            /// TR_Orders_SetCompletedAt y ajustará CompletedAt automáticamente.
            /// Devuelve la fecha y hora en que la orden fue completada.
            /// </summary>
            public DateTime? CompleteOrderAndGetCompletionTime(int orderId)
            {
                const string sql = @"
                -- 1) Actualiza el status, disparando el trigger
                UPDATE Orders
                  SET Status = 'Completed'
                WHERE OrderID = @OrderID;

                -- 2) Devuelve el campo CompletedAt que el trigger acaba de setear
                SELECT CompletedAt
                  FROM Orders
                 WHERE OrderID = @OrderID;
            ";

                using var cn = Connection.Get();
                using var cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@OrderID", orderId);

                cn.Open();
                object result = cmd.ExecuteScalar();
                if (result == null || result == DBNull.Value)
                    return null;

                return Convert.ToDateTime(result);
            }
        }
    }


