using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JLaboratories.Data;
using JLaboratories.Entity;

namespace JLaboratories.Business
{
    public class CB_Clients
    {
        private readonly CD_Clients _cd = new();

        public List<Client> ListAll() =>
            _cd.Listar();

        public int Add(Client c)
        {
            if (string.IsNullOrWhiteSpace(c.FirstName) ||
                string.IsNullOrWhiteSpace(c.LastName))
                throw new ArgumentException("Nombre y apellido son obligatorios.");

            // CD_Clients.Agregar ya devuelve el nuevo ClientID
            return _cd.Agregar(c);
        }


        public string Update(Client c)
        {
            if (c.ClientID <= 0)
                return "Cliente inválido.";

            try
            {
                _cd.Actualizar(c);
                return "Cliente actualizado.";
            }
            catch (Exception ex)
            {
                return $"Error al actualizar cliente: {ex.Message}";
            }
        }

        public string Delete(int clientId)
        {
            if (clientId <= 0)
                return "Cliente inválido.";

            try
            {
                _cd.Eliminar(clientId);
                return "Cliente eliminado.";
            }
            catch (Exception ex)
            {
                return $"Error al eliminar cliente: {ex.Message}";
            }
        }
    }
}
