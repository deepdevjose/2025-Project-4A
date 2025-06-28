using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JLaboratories.Data;
using JLaboratories.Entity;

namespace JLaboratories.Business
{
    public class CB_Tickets
    {
        private readonly CD_Tickets _cd = new();

        public string Add(Ticket t)
        {
            if (t.OrderID <= 0)
                return "Orden inválida.";

            try
            {
                int id = _cd.Agregar(t);
                return $"Ticket creado con ID {id}.";
            }
            catch (Exception ex)
            {
                return $"Error al crear ticket: {ex.Message}";
            }
        }

        public Ticket? GetByOrder(int orderId)
        {
            var ticket = _cd.ObtenerPorOrder(orderId)
                           ?? throw new InvalidOperationException($"No ticket found for OrderID {orderId}.");
            return ticket;
        }

    }
}
