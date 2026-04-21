using System;

namespace CentSible.Models
{
    public enum TransactionType
    {
        Income,
        Expense
    }

    public enum Category
    {
        Budget,
        Food,
        Transportation,
        Utilities,
        Miscellaneous,
        Health,
        Leisure
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