using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JLaboratories.Entity
{
    public class RecentOrderSimpleDto
    {
        public string Client { get; set; } = "";
        public string PCModel { get; set; } = "";
        public string? Notes { get; set; }
        public string Status { get; set; } = "";
    }
}
