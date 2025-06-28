using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JLaboratories.Entity
{
    public class Ticket
    {
        public int TicketID { get; set; }
        public int OrderID { get; set; }
        public string TicketNumber { get; set; } = string.Empty; // Default initialization
        public DateTime CreatedAt { get; set; }
        public Order? Order { get; set; } // Nullable reference type
    }
}
