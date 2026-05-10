using CentSible.Database;
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
        public List<Transaction> GetRecentTransactions(int accountID, int limit = 5)
        {
            List<Transaction> list = new List<Transaction>();
            using (MySqlConnection conn = DBConfig.GetConnection())
            {
                string query = "SELECT * FROM `transaction` WHERE accountID = @accountID " +
                               "ORDER BY date DESC, transactionID DESC LIMIT @limit";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@accountID", accountID);
                cmd.Parameters.AddWithValue("@limit", limit);

                using (MySqlDataReader data = cmd.ExecuteReader())
                {
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
                }
                return list;
            }
        }

        public List<Transaction> GetTransactions(int accountID, int month, int year)
        {
            List<Transaction> list = new List<Transaction>();
            using (MySqlConnection conn = DBConfig.GetConnection())
            {
                string query = "SELECT * FROM `transaction` " + "WHERE accountID = @accountID " + "AND MONTH(`date`) = @month " + "AND YEAR(`date`) = @year " + "ORDER BY date ASC";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@accountID", accountID);
                cmd.Parameters.AddWithValue("@month", month);
                cmd.Parameters.AddWithValue("@year", year);

                using (MySqlDataReader data = cmd.ExecuteReader())
                {
                    while (data.Read())
                    {
                        Transaction Transactions = new Transaction();
                        Transactions.TransactionID = data.GetInt32("transactionID");
                        Transactions.AccountID = data.GetInt32("accountID");
                        Transactions.Description = data.GetString("description");
                        Transactions.Amount = data.GetDecimal("amount");
                        Transactions.Date = data.GetDateTime("date");
                        Transactions.TransactionType = (TransactionType)Enum.Parse(typeof(TransactionType), data.GetString("transactionType"), true);
                        Transactions.Category = (Category)Enum.Parse(typeof(Category), data.GetString("category"), true);

                        list.Add(Transactions);
                    }
                }
            }
            return list;
        }

        public void AddTransaction(Transaction tran)
        {
            using (MySqlConnection conn = DBConfig.GetConnection())
            {
                string query = "INSERT INTO `transaction` (accountID, description, transactionType, category, amount, date) " + "VALUES (@accountID, @description, @transactionType, @category, @amount, @date)";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@accountID", tran.AccountID);
                cmd.Parameters.AddWithValue("@description", tran.Description);
                cmd.Parameters.AddWithValue("@transactionType", tran.TransactionType.ToString());
                cmd.Parameters.AddWithValue("@category", tran.Category.ToString());
                cmd.Parameters.AddWithValue("@amount", tran.Amount);
                cmd.Parameters.AddWithValue("@date", tran.Date);

                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteTransaction(int transactionID)
        {
            using (MySqlConnection conn = DBConfig.GetConnection())
            {
                string query = "DELETE FROM `transaction` WHERE transactionID = @transactionID";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@transactionID", transactionID);

                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateTransaction(Transaction tran)
        {
            using (MySqlConnection conn = DBConfig.GetConnection())
            {
                string query = "UPDATE `transaction` SET " +
                               "description = @description, " +
                               "transactionType = @transactionType, " +
                               "category = @category, " +
                               "amount = @amount, " +
                               "date = @date " +
                               "WHERE transactionID = @transactionID";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@description", tran.Description);
                cmd.Parameters.AddWithValue("@transactionType", tran.TransactionType.ToString());
                cmd.Parameters.AddWithValue("@category", tran.Category.ToString());
                cmd.Parameters.AddWithValue("@amount", tran.Amount);
                cmd.Parameters.AddWithValue("@date", tran.Date);
                cmd.Parameters.AddWithValue("@transactionID", tran.TransactionID);

                cmd.ExecuteNonQuery();
            }
        }
    }
}