using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using JLaboratories.Entity;

namespace JLaboratories.Data
{
    public class CD_Clients_SP
    {
        /// <summary>
        /// dbo.sp_ListClients callback
        /// </summary>
        public List<Client> ListarConSP()
        {
            var lista = new List<Client>();
            using var cn = Connection.Get();
            using var cmd = new SqlCommand("dbo.sp_ListClients", cn)
            {
                CommandType = CommandType.StoredProcedure
            };
            cn.Open();
            using var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                // On list we can use GetOrdinal to get the index of the column
                lista.Add(new Client
                {
                    ClientID = dr.GetInt32(dr.GetOrdinal("ClientID")),
                    FirstName = dr.GetString(dr.GetOrdinal("FirstName")),
                    LastName = dr.GetString(dr.GetOrdinal("LastName")),
                    PhoneNumber = dr.IsDBNull(dr.GetOrdinal("PhoneNumber"))
                                    ? string.Empty
                                    : dr.GetString(dr.GetOrdinal("PhoneNumber")),
                    Address = dr.IsDBNull(dr.GetOrdinal("Address"))
                                    ? string.Empty
                                    : dr.GetString(dr.GetOrdinal("Address")),
                    CreatedAt = dr.GetDateTime(dr.GetOrdinal("CreatedAt"))
                });

            }
            return lista;
        }

        /// <summary>
        /// dbo.sp_AddClient callback
        /// </summary>
        public int AgregarConSP(Client c)
        {
            using var cn = Connection.Get();
            using var cmd = new SqlCommand("dbo.sp_AddClient", cn)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.AddWithValue("@FirstName", c.FirstName);
            cmd.Parameters.AddWithValue("@LastName", c.LastName);
            cmd.Parameters.AddWithValue("@PhoneNumber", (object)c.PhoneNumber ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Address", (object)c.Address ?? DBNull.Value);

            cn.Open();
            // El SP devuelve un result‐set con NewClientID
            var newIdObj = cmd.ExecuteScalar();
            return Convert.ToInt32(newIdObj);
        }

        /// <summary>
        /// dbo.sp_UpdateClient callback
        /// </summary>
        public void ActualizarConSP(Client c)
        {
            using var cn = Connection.Get();
            using var cmd = new SqlCommand("dbo.sp_UpdateClient", cn)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.AddWithValue("@ClientID", c.ClientID);
            cmd.Parameters.AddWithValue("@FirstName", c.FirstName);
            cmd.Parameters.AddWithValue("@LastName", c.LastName);
            cmd.Parameters.AddWithValue("@PhoneNumber", (object)c.PhoneNumber ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Address", (object)c.Address ?? DBNull.Value);

            cn.Open();
            cmd.ExecuteNonQuery();
        }

        /// <summary>
        /// dbo.sp_DeleteClient callback
        /// </summary>
        public void EliminarConSP(int clientId)
        {
            using var cn = Connection.Get();
            using var cmd = new SqlCommand("dbo.sp_DeleteClient", cn)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.AddWithValue("@ClientID", clientId);

            cn.Open();
            cmd.ExecuteNonQuery();
        }
    }
}