using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JLaboratories.Entity
{
    public class ClientPCOrdersDto
    {
        public int ClientID { get; set; }
        public string ClientName { get; set; } = string.Empty;
        public int TotalOrders { get; set; }
        public int TotalDistinctPCs { get; set; }
    }


}
