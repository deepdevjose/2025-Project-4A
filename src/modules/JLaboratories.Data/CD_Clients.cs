using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JLaboratories.Entity;
using Microsoft.Data.SqlClient;

namespace JLaboratories.Data
{
    public class CD_Clients
    {
        public List<Client> Listar()
        {
            var lista = new List<Client>();
            using var cn = Connection.Get();
            using var cmd = new SqlCommand(@"
                SELECT ClientID, FirstName, LastName, PhoneNumber, Address, CreatedAt
                  FROM Clients", cn);
            cn.Open();
            using var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new Client
                {
                    ClientID = dr.GetInt32(0),
                    FirstName = dr.GetString(1),
                    LastName = dr.GetString(2),
                    PhoneNumber = dr.IsDBNull(3) ? string.Empty : dr.GetString(3),
                    Address = dr.IsDBNull(4) ? string.Empty : dr.GetString(4),
                    CreatedAt = dr.GetDateTime(5)
                });
            }
            return lista;
        }

        public int Agregar(Client c)
        {
            using var cn = Connection.Get();
            using var cmd = new SqlCommand(@"
                INSERT INTO Clients (FirstName, LastName, PhoneNumber, Address)
                OUTPUT INSERTED.ClientID
                VALUES (@fn, @ln, @ph, @ad)", cn);
            cmd.Parameters.AddWithValue("@fn", c.FirstName);
            cmd.Parameters.AddWithValue("@ln", c.LastName);
            cmd.Parameters.AddWithValue("@ph", (object)c.PhoneNumber ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@ad", (object)c.Address ?? DBNull.Value);
            cn.Open();
            return (int)cmd.ExecuteScalar();
        }

        public void Actualizar(Client c)
        {
            using var cn = Connection.Get();
            using var cmd = new SqlCommand(@"
                UPDATE Clients
                   SET FirstName   = @fn,
                       LastName    = @ln,
                       PhoneNumber = @ph,
                       Address     = @ad
                 WHERE ClientID = @id", cn);
            cmd.Parameters.AddWithValue("@fn", c.FirstName);
            cmd.Parameters.AddWithValue("@ln", c.LastName);
            cmd.Parameters.AddWithValue("@ph", (object)c.PhoneNumber ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@ad", (object)c.Address ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@id", c.ClientID);
            cn.Open();
            cmd.ExecuteNonQuery();
        }

        public void Eliminar(int clientId)
        {
            using var cn = Connection.Get();
            using var cmd = new SqlCommand(
                "DELETE FROM Clients WHERE ClientID = @id", cn);
            cmd.Parameters.AddWithValue("@id", clientId);
            cn.Open();
            cmd.ExecuteNonQuery();
        }
    }


}
