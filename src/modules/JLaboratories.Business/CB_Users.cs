using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JLaboratories.Data;
using JLaboratories.Entity;
using System.Security.Cryptography;

namespace JLaboratories.Business
{
    public class CB_Users
    {
        private readonly CD_Users _cd = new();

        /// <summary>
        /// Credential validation method.
        /// </summary>
        public bool Authenticate(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrEmpty(password))
                return false;

            // Load the user from the database
            var cipherStored = _cd.GetPasswordHash(username);
            if (cipherStored == null)
                return false;

            string plainStored;
            try
            {
                // Decrypt the stored password hash
                plainStored = AESCrypto.Decrypt(cipherStored);
            }
            catch (Exception)
            {
                // If decryption fails, return false
                return false;
            }

            // Compare the decrypted password with the provided password
            return plainStored == password;
        }


        public string Add(User u)
        {
            if (string.IsNullOrWhiteSpace(u.Username) ||
                string.IsNullOrEmpty(u.PasswordHash))
                return "Usuario o contraseña inválidos.";

            try
            {
                // Replace the password hash with the encrypted version
                u.PasswordHash = Convert.ToBase64String(SHA256.HashData(Encoding.UTF8.GetBytes(u.PasswordHash)));

                int id = _cd.Agregar(u);
                return $"Usuario creado con ID {id}.";
            }
            catch (Exception ex)
            {
                return $"Error al crear usuario: {ex.Message}";
            }
        }

        public string Update(User u)
        {
            try
            {
                _cd.Actualizar(u);
                return "Usuario actualizado.";
            }
            catch (Exception ex)
            {
                return $"Error al actualizar usuario: {ex.Message}";
            }
        }

        public string Delete(int userId)
        {
            try
            {
                _cd.Eliminar(userId);
                return "Usuario eliminado.";
            }
            catch (Exception ex)
            {
                return $"Error al eliminar usuario: {ex.Message}";
            }
        }


        public List<string> GetUsernames()
        {
            // Get the list of usernames from the database
            return [.. _cd.Listar().Select(u => u.Username)];
        }

    }
}