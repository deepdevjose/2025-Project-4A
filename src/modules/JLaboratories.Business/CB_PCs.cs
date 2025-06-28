using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JLaboratories.Data;
using JLaboratories.Entity;

namespace JLaboratories.Business
{
    public class CB_PCs
    {
        private readonly CD_PCs _cd = new();
        public List<PC> ListByClient(int clientId)
        {
            if (clientId <= 0) return []; // Explicit collection initialization
            return _cd.ListarPorCliente(clientId);
        }

        public string Add(PC p)
        {
            if (p.ClientID <= 0 || string.IsNullOrWhiteSpace(p.Model))
                return "Cliente y modelo son obligatorios.";

            try
            {
                int id = _cd.Agregar(p);
                return $"PC agregado con ID {id}.";
            }
            catch (Exception ex)
            {
                return $"Error al agregar PC: {ex.Message}";
            }
        }

        public string Update(PC p)
        {
            if (p.PCID <= 0) return "PC inválido.";

            try
            {
                _cd.Actualizar(p);
                return "PC actualizado.";
            }
            catch (Exception ex)
            {
                return $"Error al actualizar PC: {ex.Message}";
            }
        }

        public string Delete(int pcId)
        {
            if (pcId <= 0)
                return "PC inválida.";

            try
            {
                _cd.Eliminar(pcId);
                return "PC eliminada correctamente.";
            }
            catch (Exception ex)
            {
                // Violación de FK: hay órdenes apuntando a esta PC  
                return "No se puede eliminar esta PC porque hay órdenes asociadas.\n"
                     + "Por favor, elimina primero esas órdenes.";
            }
        }
    }
}
