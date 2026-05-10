using CentSible.Database;
using CentSible.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            foreach (Transaction t in transactions)
            {
                if (t.TransactionType == type)
                {
                    filtered.Add(t);
                }
            }

            return filtered;
        }
        public decimal GetTotalBudget(List<Transaction> transactions)
        {
            decimal total = 0;

            foreach (Transaction t in transactions)
            {
                if (t.TransactionType == TransactionType.Budget)
                {
                    total += t.Amount;
                }
            }

            return total;
        }
        public decimal GetTotalSpent(List<Transaction> transactions)
        {
            decimal total = 0;

            foreach (Transaction t in transactions)
            {
                if (t.TransactionType == TransactionType.Expense)
                {
                    total += t.Amount;
                }
            }

            return total;
        }
        public decimal GetRemainingBudget(List<Transaction> transactions)
        {
            return GetTotalBudget(transactions) - GetTotalSpent(transactions);
        }
        private string ValidateAmount(string amountText)
        {
            amountText = amountText.Trim();

            if (string.IsNullOrWhiteSpace(amountText))
            {
                return "Please enter an amount.";
            }
            if (amountText.Contains(','))
            {
                return "Amount cannot contain commas.";
            }

            decimal amount;
            bool isValid = decimal.TryParse(amountText, out amount);

            if (isValid == false)
            {
                return "Please enter a valid number for the amount.";
            }

            if (amount <= 0)
            {
                return "Amount must be greater than zero.";
            }

            if (amountText.Contains("."))
            {
                string[] parts = amountText.Split('.');
                if (parts[1].Length > 2)
                {
                    return "Amount can have at most 2 decimal places.";
                }
            }

            return "";
        }
        private string ValidateFields(string description, string type, string category, string amountText)
        {
            if (string.IsNullOrWhiteSpace(description))
            {
                return "Please enter a description.";
            }
            if (string.IsNullOrWhiteSpace(type))
            {
                return "Please select a transaction type.";
            }
            if (string.IsNullOrWhiteSpace(category))
            {
                return "Please select a category.";
            }
            return ValidateAmount(amountText);
        }
        private string ValidateBudget(List<Transaction> transactions, decimal amount)
        {
            decimal remainingBudget = GetRemainingBudget(transactions);
            if (remainingBudget <= 0)
            {
                return "You have no budget yet! Please add a Budget transaction first.";
            }
            if (amount > remainingBudget)
            {
                return "Insufficient budget! Your remaining budget is ₱" + remainingBudget.ToString("N0") +
                       ". You cannot add this expense.";
            }
            return "";
        }
        private string ValidateBudgetForEdit(List<Transaction> freshTransactions, decimal newAmount, int transactionID, TransactionType newType)
        {
            decimal simulatedBudget = 0;
            decimal simulatedSpent = 0;
            foreach (Transaction existing in freshTransactions)
            {
                if (existing.TransactionID == transactionID)
                {
                    continue;
                }
                if (existing.TransactionType == TransactionType.Budget)
                {
                    simulatedBudget += existing.Amount;
                }
                else
                {
                    simulatedSpent += existing.Amount;
                }
            }

            if (newType == TransactionType.Budget)
            {
                simulatedBudget += newAmount;
            }
            else
            {
                simulatedSpent += newAmount;
            }

            decimal simulatedRemaining = simulatedBudget - simulatedSpent;
            if (simulatedBudget == 0)
            {
                return "You have no budget yet! Please add a Budget transaction first.";
            }
            if (simulatedRemaining < 0)
            {
                return "This edit would result in a negative remaining budget of ₱" + Math.Abs(simulatedRemaining).ToString("N2") +
                       ". Please adjust the amount.";
            }
            return "";
        }
        public string AddNewTransaction(int accountID, string description, string type, string category, string amountText, List<Transaction> transactions)
        {
            string error = ValidateFields(description, type, category, amountText);
            if (error != "")
            {
                return error;
            }

            decimal amount = decimal.Parse(amountText.Trim());
            TransactionType transactionType = (TransactionType)Enum.Parse(typeof(TransactionType), type);
            Category transactionCategory = (Category)Enum.Parse(typeof(Category), category);

            if (transactionType == TransactionType.Expense)
            {
                string budgetError = ValidateBudget(transactions, amount);
                if (budgetError != "")
                {
                    return budgetError;
                }
            }

            Transaction t = new Transaction();
            t.AccountID = accountID;
            t.Description = description;
            t.Amount = amount;
            t.Date = DateTime.Now;
            t.TransactionType = transactionType;
            t.Category = transactionCategory;

            transactionDB.AddTransaction(t);

            return "";
        }
        public string UpdateExistingTransaction(int accountID, int transactionID, string description, string type, string category, string amountText, int month, int year)
        {
            string error = ValidateFields(description, type, category, amountText);
            if (error != "") { return error; }

            decimal amount = decimal.Parse(amountText.Trim());
            TransactionType transactionType = (TransactionType)Enum.Parse(typeof(TransactionType), type);
            Category transactionCategory = (Category)Enum.Parse(typeof(Category), category);

            List<Transaction> freshTransactions = transactionDB.GetTransactions(accountID, month, year);

            TransactionType originalType = TransactionType.Expense;
            foreach (Transaction existing in freshTransactions)
            {
                if (existing.TransactionID == transactionID)
                {
                    originalType = existing.TransactionType;
                }
            }

            string budgetError = ValidateBudgetForEdit(freshTransactions, amount, transactionID, transactionType);
            if (budgetError != "") { return budgetError; }
           
            Transaction t = new Transaction();
            t.TransactionID = transactionID;
            t.AccountID = accountID;
            t.Description = description;
            t.Amount = amount;
            t.Date = DateTime.Now;
            t.TransactionType = transactionType;
            t.Category = transactionCategory;

            transactionDB.UpdateTransaction(t);

            return "";
        }
        public void DeleteTransaction(int transactionID)
        {
            transactionDB.DeleteTransaction(transactionID);
        }
    }
}