using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CentSible.Models;
using MySql.Data.MySqlClient;

namespace CentSible.Database
{
    public class SummaryDB
    {
        public Dictionary<string, decimal> GetSpendingByCategory(int accountID, int month, int year)
        {
            Dictionary<string, decimal> result = new Dictionary<string, decimal>();
            using (MySqlConnection conn = DBConfig.GetConnection())
            {
                string query = "SELECT category, SUM(amount) AS total " +
                           "FROM `transaction` " +
                           "WHERE accountID = @accountID " +
                           "AND transactionType = 'Expense' " +
                           "AND MONTH(`date`) = @month " +
                           "AND YEAR(`date`) = @year " +
                           "GROUP BY category";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@accountID", accountID);
                cmd.Parameters.AddWithValue("@month", month);
                cmd.Parameters.AddWithValue("@year", year);

                using (MySqlDataReader data = cmd.ExecuteReader())
                {
                    while (data.Read())
                    {
                        string category = data.GetString("category");
                        decimal total = data.GetDecimal("total");

                        result.Add(category, total);
                    }
                }             
            }
            return result;
        }
    }
}
