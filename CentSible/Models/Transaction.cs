using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentSible.Models
{
    public enum TransactionType
    {
        Budget,
        Expense
    }

    public enum Category
    {
        Income,
        Allowance,
        Food,
        Transportation,
        Utilities,
        Miscellaneous,
        Health,
        Leisure,
        Others
    }
    public class Transaction
    {
        public int TransactionID { get; set; }
        public int AccountID { get; set; }
        public string Description { get; set; }
        public TransactionType TransactionType { get; set; }
        public Category Category { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
    }
}
