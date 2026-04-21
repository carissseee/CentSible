using System;
using MySql.Data.MySqlClient;

namespace CentSible.Database
{
    public class CentSibleConnection
    {
        private readonly string connectionString = "Server=localhost;Port=3306;Database=centsible;Uid=root;Pwd=;";

        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }
}