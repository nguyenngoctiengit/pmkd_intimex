using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace pmkd.Models
{
    public class TestConnection
    {
        SqlConnection connection;
        public TestConnection (string connectionstring)
        {
            connection = new SqlConnection(connectionstring);
        }
        public bool IsConnection
        {
            get
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
