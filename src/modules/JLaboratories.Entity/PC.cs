using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JLaboratories.Entity
{
    public class PC
    {
        public int PCID { get; set; }
        public int ClientID { get; set; }
        public string Model { get; set; } = null!;
        public string SerialNumber { get; set; } = null!;
        public DateTime CreatedAt { get; set; }

        public Client Client { get; set; } = null!;
        public List<Order> Orders { get; set; } = new();
    }
}
