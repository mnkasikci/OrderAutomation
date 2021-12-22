using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderAutomation
{
    public static class DBHelper
    {

        private const string connectionString = "Data Source=localhost;Initial Catalog=OrderAutomation;Integrated Security=True";
        private static SqlConnection Singleton;

        public static SqlConnection GetConnectionItem()
        {
            if(Singleton==null)
                Singleton = new SqlConnection(connectionString);
            return Singleton;
        }
        
    }
}
