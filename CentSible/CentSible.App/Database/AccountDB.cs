using CentSible.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;


namespace CentSible.Database
{
    public class AccountDB
    {


        public Account GetAccount(string username, string password)
        {
            using (MySqlConnection conn = new MySqlConnection(CentSibleConnection.ConnectionString))
            {
                conn.Open();
                string query = "SELECT * FROM account WHERE username = @u AND BINARY password = @p";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@u", username);
                    cmd.Parameters.AddWithValue("@p", password);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Account
                            {
                                AccountID = reader.GetInt32("accountID"),
                                Username = reader.GetString("username"),
                                LoginStreak = reader.GetInt32("loginStreak"),
                                LongestStreak = reader.GetInt32("longestStreak"),
                                LastLoginDate = reader.IsDBNull(reader.GetOrdinal("lastLoginDate")) ? (DateTime?)null : reader.GetDateTime("lastLoginDate"),
                                CreatedAt = reader.IsDBNull(reader.GetOrdinal("createdAt")) ? (DateTime?)null : reader.GetDateTime("createdAt")
                            };
                        }
                    }
                }
            }
            return null;
        }

        public void UpdateStreakAndDate(int id, int streak, int longestStreak)
        {
            using (MySqlConnection conn = new MySqlConnection(CentSibleConnection.ConnectionString))
            {
                conn.Open();
                string query = "UPDATE account SET loginStreak = @s, longestStreak = @ls, lastLoginDate = @d WHERE accountID = @id";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@s", streak);
                    cmd.Parameters.AddWithValue("@ls", longestStreak);
                    cmd.Parameters.AddWithValue("@d", DateTime.Today);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void RegisterAccount(string username, string password)
        {
            using (MySqlConnection conn = new MySqlConnection(CentSibleConnection.ConnectionString))
            {
                conn.Open();
                string query = "INSERT INTO account (username, password, loginStreak, longestStreak, lastLoginDate) VALUES (@u, @p, 0, 0, NULL)";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@u", username);
                    cmd.Parameters.AddWithValue("@p", password);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}