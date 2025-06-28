using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JLaboratories.Entity
{
    public class OrderSummaryDto
    {
        public int PendingCount { get; set; }
        public int UrgentCount { get; set; }
        public int CompletedCount { get; set; }
    }
}
