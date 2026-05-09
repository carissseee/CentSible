using MySql.Data.MySqlClient;
using CentSible.Models;
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
        
        public Account GetAccount(string username)
        {
            using (MySqlConnection conn = DBConfig.GetConnection())
            {
                string query = "SELECT * FROM account WHERE username = @u";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@u", username);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Account
                            {
                                AccountID = reader.GetInt32("accountID"),
                                Username = reader.GetString("username"),
                                Password = reader.GetString("password"),
                                LoginStreak = reader.GetInt32("loginStreak"),
                                LongestStreak = reader.GetInt32("longestStreak"),
                                LastLoginDate = reader.IsDBNull(reader.GetOrdinal("lastLoginDate")) ? (DateTime?)null : reader.GetDateTime("lastLoginDate"),
                                CreatedAt = reader.IsDBNull(reader.GetOrdinal("createdAt"))  ? (DateTime?)null: reader.GetDateTime("createdAt")
                            };
                        }
                    }
                }
            }
            return null;
        }

        public void UpdateStreakAndDate(int id, int streak, int longestStreak)
        {
            using (MySqlConnection conn = DBConfig.GetConnection())
            {
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

        public void RegisterAccount(Account user)
        {
            using (MySqlConnection conn = DBConfig.GetConnection())
            {
                string query = "INSERT INTO account (username, password, loginStreak, longestStreak, lastLoginDate) " +
                               "VALUES (@u, @p, @s, @ls, NULL)";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@u", user.Username);
                    cmd.Parameters.AddWithValue("@p", user.Password);
                    cmd.Parameters.AddWithValue("@s", user.LoginStreak);
                    cmd.Parameters.AddWithValue("@ls", user.LongestStreak);
                    cmd.ExecuteNonQuery();
                }
            }
        }

    }
}