using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2
{
    internal class Connections
    {
        public static string SQLConString = """
            Server=.;
            Database = EFDAY2;
            Integrated Security = True;
            Trusted_Connection = true;
            TrustServerCertificate = True
            """;
    }
}
