using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

using JLaboratories.Entity;

namespace JLaboratories.Data
{
    public class CD_Tickets
    {
        public int Agregar(Ticket t)
        {
            using var cn = Connection.Get();
            using var cmd = new SqlCommand(@"
                INSERT INTO Tickets (OrderID, TicketNumber)
                OUTPUT INSERTED.TicketID
                VALUES (@oid, @tn)", cn);
            cmd.Parameters.AddWithValue("@oid", t.OrderID);
            cmd.Parameters.AddWithValue("@tn", t.TicketNumber);
            cn.Open();
            return (int)cmd.ExecuteScalar();
        }

        public Ticket? ObtenerPorOrder(int orderId)
        {
            using var cn = Connection.Get();
            using var cmd = new SqlCommand(@"
                SELECT TicketID, OrderID, TicketNumber, CreatedAt
                  FROM Tickets
                 WHERE OrderID = @oid", cn);
            cmd.Parameters.AddWithValue("@oid", orderId);
            cn.Open();
            using var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                return new Ticket
                {
                    TicketID = dr.GetInt32(0),
                    OrderID = dr.GetInt32(1),
                    TicketNumber = dr.GetString(2),
                    CreatedAt = dr.GetDateTime(3)
                };
            }
            return null;
        }
    }
}
