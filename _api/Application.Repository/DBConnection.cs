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
            return new SqlConnection("{yourconnectionstring}");
        }
    }
}
