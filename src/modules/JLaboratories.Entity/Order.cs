using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JLaboratories.Entity
{
    public class Order
    {
        public int OrderID { get; set; }
        public int ClientID { get; set; }
        public int? PCID { get; set; } // Nullable for optional PCID
        public string Notes { get; set; } = string.Empty; // Default initialization
        public bool IsUrgent { get; set; }
        public string Status { get; set; } = string.Empty; // Default initialization
        public DateTime CreatedAt { get; set; }
        public DateTime? CompletedAt { get; set; } // Nullable for optional completion date
        public Client? Client { get; set; } // Nullable reference type
        public PC? PC { get; set; } // Nullable reference type
        public Ticket? Ticket { get; set; } // Nullable reference type
    }

}
