using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JLaboratories.Entity;
using Microsoft.Data.SqlClient;

namespace JLaboratories.Data
{
    public class CD_Users
    {
        public string GetPasswordHash(string username)
        {
            using var cn = Connection.Get();
            using var cmd = new SqlCommand(
                "SELECT PasswordHash FROM Users WHERE Username = @u", cn);
            cmd.Parameters.AddWithValue("@u", username);
            cn.Open();
            var result = cmd.ExecuteScalar();
            return result is DBNull ? string.Empty : (string)result;
        }

        public int Agregar(User u)
        {
            using var cn = Connection.Get();
            using var cmd = new SqlCommand(@"
                INSERT INTO Users (Username, PasswordHash, FullName)
                OUTPUT INSERTED.UserID
                VALUES (@usr, @pwd, @fn)", cn);
            cmd.Parameters.AddWithValue("@usr", u.Username);
            cmd.Parameters.AddWithValue("@pwd", u.PasswordHash);
            cmd.Parameters.AddWithValue("@fn", (object)u.FullName ?? DBNull.Value);
            cn.Open();
            return (int)cmd.ExecuteScalar();
        }

        public void Actualizar(User u)
        {
            using var cn = Connection.Get();
            using var cmd = new SqlCommand(@"
                UPDATE Users
                   SET PasswordHash = @pwd,
                       FullName     = @fn
                 WHERE UserID = @id", cn);
            cmd.Parameters.AddWithValue("@pwd", u.PasswordHash);
            cmd.Parameters.AddWithValue("@fn", (object)u.FullName ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@id", u.UserID);
            cn.Open();
            cmd.ExecuteNonQuery();
        }

        public void Eliminar(int userId)
        {
            using var cn = Connection.Get();
            using var cmd = new SqlCommand(
                "DELETE FROM Users WHERE UserID = @id", cn);
            cmd.Parameters.AddWithValue("@id", userId);
            cn.Open();
            cmd.ExecuteNonQuery();
        }
        public List<User> Listar()
        {
            var lista = new List<User>();
            using var cn = Connection.Get();
            using var cmd = new SqlCommand(
                "SELECT UserID, Username, FullName, CreatedAt FROM Users", cn);
            cn.Open();
            using var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new User
                {
                    UserID = dr.GetInt32(0),
                    Username = dr.GetString(1),
                    FullName = dr.IsDBNull(2) ? null! : dr.GetString(2),
                    CreatedAt = dr.GetDateTime(3)
                });
            }
            return lista;
        }

    }
}
