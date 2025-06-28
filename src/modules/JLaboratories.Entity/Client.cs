using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JLaboratories.Entity
{
    public class Client
    {
        public int ClientID { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
        public string Address { get; set; } = null!;
        public DateTime CreatedAt { get; set; }

        public List<PC> Orders { get; set; } = new();
        public List<Order> PCs { get; set; } = new();
        public string FullName => $"{FirstName} {LastName}";
    }
}
