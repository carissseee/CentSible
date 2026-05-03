using CentSible.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CentSible.Forms
{
    public partial class TransactionForm
    {
        private void EditTransaction(int rowIndex)
        {
            _isEditing = true;
            _editingRowIndex = rowIndex;

            var row = dgvTransaction.Rows[rowIndex];
            string rawAmount = row.Cells["colAmount"].Value?.ToString()
                .Replace("+₱", "")
                .Replace("-₱", "")
                .Replace(",", "")
                .Trim();

            row.Cells["colAmount"].Value = rawAmount;
            row.Cells["colDelete"].Value = "❌";

            dgvTransaction.CurrentCell = dgvTransaction.Rows[rowIndex].Cells["colDescription"];
            dgvTransaction.BeginEdit(true);
        }
        private void SaveEditedTransaction(int rowIndex)
        {
            try
            {
                var row = dgvTransaction.Rows[rowIndex];
                if (string.IsNullOrWhiteSpace(row.Cells["colDescription"].Value?.ToString()))
                {
                    MessageBox.Show("Please enter a description.");
                    return;
                }
                if (string.IsNullOrWhiteSpace(row.Cells["colType"].Value?.ToString()))
                {
                    MessageBox.Show("Please select a transaction type.");
                    return;
                }
                if (string.IsNullOrWhiteSpace(row.Cells["colCategory"].Value?.ToString()))
                {
                    MessageBox.Show("Please select a category.");
                    return;
                }
                if (string.IsNullOrWhiteSpace(row.Cells["colAmount"].Value?.ToString()))
                {
                    MessageBox.Show("Please enter an amount.");
                    return;
                }

                decimal amount;
                bool isValidAmount = decimal.TryParse(
                    row.Cells["colAmount"].Value.ToString()
                        .Replace("₱", "")
                        .Replace("+", "")
                        .Replace("-", "")
                        .Replace(",", "")
                        .Trim(),
                    out amount
                );

                if (isValidAmount == false)
                {
                    MessageBox.Show("Please enter a valid number for the amount.");
                    return;
                }
                if (amount <= 0)
                {
                    MessageBox.Show("Amount must be greater than zero.");
                    return;
                }

                Transaction transaction = new Transaction();
                transaction.TransactionID = Convert.ToInt32(row.Cells["colTransactionID"].Value);
                transaction.AccountID = _user.AccountID;
                transaction.Description = row.Cells["colDescription"].Value.ToString();
                transaction.Date = DateTime.Now;
                transaction.Amount = amount;
                transaction.TransactionType = (TransactionType)Enum.Parse(typeof(TransactionType), row.Cells["colType"].Value.ToString());
                
                if (transaction.TransactionType == TransactionType.Expense)
                {
                    decimal originalAmount = 0;
                    foreach (Transaction existing in transactions)
                    {
                        if (existing.TransactionID == transaction.TransactionID)
                        {
                            originalAmount = existing.Amount;
                        }
                    }

                    decimal remainingBudget = transactionLogic.GetRemainingBudget(transactions) + originalAmount;
                    if (remainingBudget <= 0)
                    {
                        MessageBox.Show("You have no budget yet! Please add a Budget transaction first.", "No Budget");
                        return;
                    }
                    if (transaction.Amount > remainingBudget)
                    {
                        MessageBox.Show("Insufficient budget! Your remaining budget is ₱" + remainingBudget.ToString("N0") + ". You cannot add this expense.", "Insufficient Budget");
                        return;
                    }
                }

                transaction.Category = (Category)Enum.Parse(typeof(Category), row.Cells["colCategory"].Value.ToString());

                transactionLogic.UpdateTransaction(transaction);
                LoadTransactions();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating: " + ex.Message);
            }
        }
    }
}
