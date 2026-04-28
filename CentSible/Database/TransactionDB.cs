using CentSible.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentSible.Database
{
    public class TransactionDB
    {
        public List<Transaction> GetTransactions(int accountID, int month, int year)
        {
            List<Transaction> list = new List<Transaction>();

            MySqlConnection conn = new MySqlConnection(DBConfig.ConnectionString);
            conn.Open();

            string query = "SELECT * FROM transaction " + "WHERE accountID = @accountID " + "AND MONTH(date) = @month " + "AND YEAR(date = @year " + "ORDER BY date ACS";

            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@accountID", accountID);
            cmd.Parameters.AddWithValue("@month", month);
            cmd.Parameters.AddWithValue("@year", year);

            MySqlDataReader data = cmd.ExecuteReader();

            while (data.Read())
            {
                Transaction Transactions = new Transaction();
                Transactions.TransactionID = data.GetInt32("transactionID");
                Transactions.AccountID = data.GetInt32("accountID");
                Transactions.Description = data.GetString("description");
                Transactions.Amount = data.GetDecimal("amount");
                Transactions.Date = data.GetDateTime("date");
                Transactions.TransactionType = (TransactionType)Enum.Parse(typeof(TransactionType), data.GetString("transactionType"));
                Transactions.Category = (Category)Enum.Parse(typeof(Category), data.GetString("category"));

                list.Add(Transactions);
            }
            
            data.Close();
            cmd.Dispose();
            conn.Close();

            return list;
        }
    }
}
