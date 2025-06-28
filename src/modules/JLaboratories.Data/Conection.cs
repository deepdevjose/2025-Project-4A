using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Microsoft.Data.SqlClient;

namespace JLaboratories.Data
{
    public static class Connection
    {
        private static readonly string _cs =
            ConfigurationManager.ConnectionStrings["JLaboratories"].ConnectionString;
        public static SqlConnection Get() => new(_cs);


    }
}

