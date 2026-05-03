using CentSible.Models;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CentSible.Forms
{
    public partial class TransactionForm
    {
        private void LoadTransactions()
        {
            if (cmbMonth.SelectedIndex < 0 || cmbYear.SelectedItem == null)
            {
                return;
            }

            dgvTransaction.Rows.Clear();
            _isAddingNew = false;
            _isEditing = false;
            _editingRowIndex = -1;
            SetFilterButtons(true);

            int month = cmbMonth.SelectedIndex + 1;
            int year = int.Parse(cmbYear.SelectedItem.ToString());
            lblDate.Text = new DateTime(year, month, 1).ToString("MMMM yyyy");

            transactions = transactionLogic.GetTransactions(_user.AccountID, month, year);
            lblBudget2.Text = "₱ " + transactionLogic.GetTotalBudget(transactions).ToString("N0");
            lblSpent2.Text = "₱ " + transactionLogic.GetTotalSpent(transactions).ToString("N0");
            lblRemaining2.Text = "₱ " + transactionLogic.GetRemainingBudget(transactions).ToString("N0");

            foreach (Transaction transaction in transactions)
            {
                string sign = "";
                if (transaction.TransactionType == TransactionType.Budget)
                {
                    sign = "+₱ ";
                }
                else
                {
                    sign = "-₱ ";
                }

                dgvTransaction.Rows.Add(
                    transaction.Date.ToString("MMM d"),
                    transaction.Description,
                    transaction.TransactionType.ToString(),
                    transaction.Category.ToString(),
                    sign + transaction.Amount.ToString("N0"),
                    "💾",
                    "🗑️",
                    transaction.TransactionID
                );
            }
        }

        private void DisplayTransactions(List<Transaction> list)
        {
            dgvTransaction.Rows.Clear();

            foreach(Transaction transaction in list)
            {
                string sign = "";
                if (transaction.TransactionType == TransactionType.Budget)
                {
                    sign = "+₱ ";
                }
                else
                {
                    sign = "-₱ ";
                }

                dgvTransaction.Rows.Add(
                    transaction.Date.ToString("MMM d"),
                    transaction.Description,
                    transaction.TransactionType.ToString(),
                    transaction.Category.ToString(),
                    sign + transaction.Amount.ToString("N0"),
                    "💾",
                    "🗑️",
                    transaction.TransactionID
                );
            }
        }

        private void SetFilterButtons(bool enabled)
        {
            btnAll.Enabled = enabled;
            btnExpense.Enabled = enabled;
            btnBudget.Enabled = enabled;
        }
    }
}
