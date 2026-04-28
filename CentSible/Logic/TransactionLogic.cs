using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CentSible.Models;
using CentSible.Database;

namespace CentSible.Logic
{
    public class TransactionLogic
    {
        private TransactionDB transactionDB = new TransactionDB();

        public List<Transaction> GetTransactions(int accountID, int month, int year)
        {
            return transactionDB.GetTransactions(accountID, month, year);
        }

        public List<Transaction> GetByType(List<Transaction> transactions, TransactionType type)
        {
            List<Transaction> filtered = new List<Transaction>();

            foreach(Transaction t in transactions)
            {
                if(t.TransactionType == type)
                {
                    filtered.Add(t);
                }
            }
            return filtered;
        }

        public decimal GetTotalBudget(List<Transaction> transactions)
        {
            decimal total = 0;
            foreach(Transaction t in transactions)
            {
                if(t.TransactionType == TransactionType.Budget)
                {
                    total += t.Amount;
                }
            }
            return total;
        }

        public decimal GetTotalSpent(List<Transaction> transactions)
        {
            decimal total = 0;
            foreach(Transaction t in transactions)
            {
                if(t.TransactionType == TransactionType.Expense)
                {
                    total += t.Amount;
                }
            }
            return total;
        }

        public decimal GetRemainingBudget(List<Transaction> transactions)
        {
            decimal totalBudget = GetTotalBudget(transactions);
            decimal totalSpent = GetTotalSpent(transactions);

            return totalBudget - totalSpent;
        }
    }
}
