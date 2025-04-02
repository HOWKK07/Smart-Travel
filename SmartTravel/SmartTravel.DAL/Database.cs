using System;
using System.Data.SqlClient;

namespace SmartTravel.DAL
{
    public class Database
    {
        private static string connectionString = @"Data Source=YourServerName;Initial Catalog=YourDatabaseName;Integrated Security=True";

        public static SqlConnection GetConnection()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            return conn;
        }
    }
}
