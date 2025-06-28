using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JLaboratories.Entity;
using Microsoft.Data.SqlClient;

namespace JLaboratories.Data
{
    public class CD_PCs
    {
        public List<PC> ListarPorCliente(int clientId)
        {
            var lista = new List<PC>();
            using var cn = Connection.Get();
            using var cmd = new SqlCommand(@"
                SELECT PCID, ClientID, Model, SerialNumber, CreatedAt
                  FROM PCs
                 WHERE ClientID = @cid", cn);
            cmd.Parameters.AddWithValue("@cid", clientId);
            cn.Open();
            using var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new PC
                {
                    PCID = dr.GetInt32(0),
                    ClientID = dr.GetInt32(1),
                    Model = dr.GetString(2),
                    SerialNumber = dr.IsDBNull(3) ? string.Empty : dr.GetString(3),
                    CreatedAt = dr.GetDateTime(4)
                });
            }
            return lista;
        }

        public int Agregar(PC p)
        {
            using var cn = Connection.Get();
            using var cmd = new SqlCommand(@"
                INSERT INTO PCs (ClientID, Model, SerialNumber)
                OUTPUT INSERTED.PCID
                VALUES (@cid, @mod, @ser)", cn);
            cmd.Parameters.AddWithValue("@cid", p.ClientID);
            cmd.Parameters.AddWithValue("@mod", p.Model);
            cmd.Parameters.AddWithValue("@ser", (object)p.SerialNumber ?? DBNull.Value);
            cn.Open();
            return (int)cmd.ExecuteScalar();
        }

        public void Actualizar(PC p)
        {
            using var cn = Connection.Get();
            using var cmd = new SqlCommand(@"
                UPDATE PCs
                   SET Model        = @mod,
                       SerialNumber = @ser
                 WHERE PCID = @id", cn);
            cmd.Parameters.AddWithValue("@mod", p.Model);
            cmd.Parameters.AddWithValue("@ser", (object)p.SerialNumber ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@id", p.PCID);
            cn.Open();
            cmd.ExecuteNonQuery();
        }

        public void Eliminar(int pcId)
        {
            using var cn = Connection.Get();
            using var cmd = new SqlCommand(
                "DELETE FROM PCs WHERE PCID = @id", cn);
            cmd.Parameters.AddWithValue("@id", pcId);
            cn.Open();
            cmd.ExecuteNonQuery();
        }
    }
}
