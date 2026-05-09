using System;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace CentSible.Database
{
    public static class DBConfig
    {
        private static readonly string ConnectionString =
            ConfigurationManager.ConnectionStrings["CentSible"].ConnectionString;

        public static MySqlConnection GetConnection()
        {
            try
            { 
                MySqlConnection conn = new MySqlConnection(ConnectionString);
                conn.Open();
                return conn;
            }
            catch (MySqlException)
            {
                throw new Exception("Unable to connect to the database. Please try again.");
            }
        }
    }
}