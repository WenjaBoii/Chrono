using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Chrono
{


        public static class DatabaseHelper
    {
        // returns a new MySQL connection object
        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(
                ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString);
        }

        // optional: test if the database is reachable
        public static bool TestConnection()
        {
            try
            {
                using (var conn = GetConnection())
                {
                    conn.Open();
                    return true;  // connection successful
                }
            }
            catch
            {
                return false; // failed
            }
        }
    }
}


    internal class DatabaseHelper
    {
    }

    
