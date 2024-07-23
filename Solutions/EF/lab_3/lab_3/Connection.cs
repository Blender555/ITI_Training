using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3
{
    internal static class Connection
    {
        public static string SQLConString = """
            Server=.;
            Database = EFDAY3;
            Integrated Security = True;
            Trusted_Connection = true;
            TrustServerCertificate = True
            """;
    }
}
