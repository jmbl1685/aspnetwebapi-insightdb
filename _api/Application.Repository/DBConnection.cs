using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Repository
{
    public static class DBConnection
    {
        public static SqlConnection GetConnection()
        {
            return new SqlConnection("Server=tcp:azure-jbatty.database.windows.net,1433;Initial Catalog=azure-jbatty;Persist Security Info=False;User ID=jbatty;Password=Jbatt4-18;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        }
    }
}
