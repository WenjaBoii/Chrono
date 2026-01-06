using System;
using MySql.Data.MySqlClient;

namespace Chrono
{
    public static class DatabaseHelper
    {
        // Hardcoded connection string - update with your MySQL details
        private static string connectionString = "Server=10.153.174.183;Database=2dchrono_db;Uid=chrono_user;Pwd=cs2dgroup1;";

        // Returns a new MySQL connection object
        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }

        // Optional: test if the database is reachable
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