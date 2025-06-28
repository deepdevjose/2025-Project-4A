using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JLaboratories.Data;
using JLaboratories.Entity;

namespace JLaboratories.Business
{
    public class CB_Orders
    {
        private readonly CD_Orders _cd = new();
        private readonly CD_Tickets _cdt = new();

        public List<RecentOrderSimpleDto> ListRecentSimple()
            => _cd.ListRecentSimple();


        public OrderSummaryDto GetOrderSummary()
            => _cd.GetSummary();
        public List<Order> ListRecent(int top = 10)
        {
            // Podrías añadir un método en CD_Orders para TOP n
            var all = CD_Orders.ListarTodos(); // Changed to use the type name
            return all.Count <= top ? all : all.GetRange(0, top);
        }

        public (int pending, int urgent, int completed) GetSummaryCounts()
        {
            var all = CD_Orders.ListarTodos(); // Changed to use the type name
            int p = 0, u = 0, c = 0;
            foreach (var o in all)
            {
                if (o.Status == "Pending") p++;
                else if (o.Status == "Urgent") u++;
                else if (o.Status == "Completed") c++;
            }
            return (p, u, c);
        }


        /// <summary>
        /// Crea una orden y genera su ticket.
        /// </summary>
        public string CreateWithTicket(Order o)
        {
            if (o.ClientID <= 0)
                return "Cliente inválido.";

            // Status inicial: Pending o Urgent
            o.Status = o.IsUrgent ? "Urgent" : "Pending";

            try
            {
                int orderId = _cd.Agregar(o);

                // Generar ticket
                var t = new Ticket
                {
                    OrderID = orderId,
                    TicketNumber = $"TKT{orderId:00000}"
                };
                int ticketId = _cdt.Agregar(t);

                return $"Orden {orderId} creada con ticket {ticketId}.";
            }
            catch (Exception ex)
            {
                return $"Error al crear orden: {ex.Message}";
            }
        }

        public string UpdateStatus(int orderId, string status, bool isUrgent)
        {
            try
            {
                _cd.ActualizarStatus(orderId, status, isUrgent);
                return "Orden actualizada.";
            }
            catch (Exception ex)
            {
                return $"Error al actualizar orden: {ex.Message}";
            }
        }

        public string Delete(int orderId)
        {
            try
            {
                _cd.Eliminar(orderId);
                return "Orden eliminada.";
            }
            catch (Exception ex)
            {
                return $"Error al eliminar orden: {ex.Message}";
            }
        }

        public List<Order> ListByClient(int value)
        {
            throw new NotImplementedException();
        }
    }
}
