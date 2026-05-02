using CentSible.Logic;
using CentSible.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CentSible.Forms
{
    public partial class TransactionForm : Form
    {
        private Form _home;
        private Account _user;
        private bool _isNavigating = false;
        private bool _isAddingNew = false;
        private bool _isEditing = false;
        private int _editingRowIndex = -1;

        private TransactionLogic transactionLogic = new TransactionLogic();
        private List<Transaction> transactions = new List<Transaction>();
        public TransactionForm(Form home, Account user)
        {
            InitializeComponent(); 
            _home = home;          
            _user = user;          
        }
        private void TransactionForm_Load(object sender, EventArgs e)
        {
            if (_user == null)
            {
                return;
            }

            TranButtonGoal.BackColor = Color.FromArgb(212, 236, 204);
            TranButtonGoal.ForeColor = Color.Black;

            cmbYear.SelectedIndexChanged -= cmbYear_SelectedIndexChanged;
            int currentYear = DateTime.Now.Year;
            for (int i = currentYear; i >= currentYear - 5; i--)
            {
                cmbYear.Items.Add(i.ToString());
            }
            cmbYear.SelectedIndex = 0;
            cmbYear.SelectedIndexChanged += cmbYear_SelectedIndexChanged;

            cmbMonth.SelectedIndexChanged -= cmbMonth_SelectedIndexChanged;
            for (int i = 1; i <= 12; i++)
            {
                cmbMonth.Items.Add(new DateTime(2000, i, 1).ToString("MMMM"));
            }
            cmbMonth.SelectedIndex = DateTime.Now.Month - 1;
            cmbMonth.SelectedIndexChanged += cmbMonth_SelectedIndexChanged;

            LoadTransactions();
        }
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

            int month = cmbMonth.SelectedIndex + 1;
            int year = int.Parse(cmbYear.SelectedItem.ToString());

            lblDate.Text = new DateTime(year, month, 1).ToString("MMMM yyyy");
            transactions = transactionLogic.GetTransactions(_user.AccountID, month, year);

            lblBudget2.Text = "₱ " + transactionLogic.GetTotalBudget(transactions).ToString("N0");
            lblSpent2.Text = "₱ " + transactionLogic.GetTotalSpent(transactions).ToString("N0");
            lblRemaining2.Text = "₱ " + transactionLogic.GetRemainingBudget(transactions).ToString("N0");

            foreach (Transaction t in transactions)
            {
                string sign = "";
                if (t.TransactionType == TransactionType.Budget)
                {
                    sign = "+₱";
                }
                else
                {
                    sign = "-₱";
                }

                dgvTransaction.Rows.Add(
                t.Date.ToString("MMM d"),      
                t.Description,                  
                t.TransactionType.ToString(),   
                t.Category.ToString(),         
                sign + t.Amount.ToString("N0"), 
                "💾",                          
                "🗑️",                       
                t.TransactionID                 
                );
            }
        }
        private void DisplayTransactions(List<Transaction> list)
        {
            dgvTransaction.Rows.Clear();

            foreach (Transaction t in list)
            {
                string sign = "";
                if (t.TransactionType == TransactionType.Budget)
                {
                    sign = "+₱";
                }
                else
                {
                    sign = "-₱";
                }

                dgvTransaction.Rows.Add(
                t.Date.ToString("MMM d"),
                t.Description,
                t.TransactionType.ToString(),
                t.Category.ToString(),
                sign + t.Amount.ToString("N0"),
                "💾",
                "🗑️",
                t.TransactionID
                );
            }
        }
        private void btnAddTransaction_Click(object sender, EventArgs e)
        {
            if (_isAddingNew == true)
            {
                MessageBox.Show("Please save the current new transaction first.");
                return;
            }

            if (_isEditing == true)
            {
                MessageBox.Show("Please save the current edited transaction first.");
                return;
            }

            _isAddingNew = true;
            dgvTransaction.Rows.Add(
                DateTime.Now.ToString("MMM d"),
                "",                           
                "",                            
                "",                             
                "",                        
                "💾",                          
                "❌",                           
                -1                              
            );

            int newRowIndex = dgvTransaction.Rows.Count - 1;
            dgvTransaction.CurrentCell = dgvTransaction.Rows[newRowIndex].Cells["colDescription"];
            dgvTransaction.BeginEdit(true);
        }

        private void SaveNewTransaction(int rowIndex)
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
                bool isValidAmount = decimal.TryParse(row.Cells["colAmount"].Value.ToString(), out amount);

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
                Transaction t = new Transaction();
                t.AccountID = _user.AccountID;
                t.Description = row.Cells["colDescription"].Value.ToString();
                t.Date = DateTime.Now;
                t.Amount = amount;
                t.TransactionType = (TransactionType)Enum.Parse(typeof(TransactionType), row.Cells["colType"].Value.ToString());
                if (t.TransactionType == TransactionType.Expense)
                {
                    decimal originalAmount = 0;
                    foreach (Transaction existing in transactions)
                    {
                        if (existing.TransactionID == t.TransactionID)
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
                    if (t.Amount > remainingBudget)
                    {
                        MessageBox.Show("Insufficient budget! Your remaining budget is ₱" + remainingBudget.ToString("N0") + ". You cannot add this expense.","Insufficient Budget");
                        return;
                    }
                }
                t.Category = (Category)Enum.Parse(typeof(Category),row.Cells["colCategory"].Value.ToString());
                transactionLogic.AddTransaction(t);

                LoadTransactions();
            }
            catch (Exception ex)
            { 
                MessageBox.Show("Error saving: " + ex.Message);
            }
        }
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

                Transaction t = new Transaction();
                t.TransactionID = Convert.ToInt32(row.Cells["colTransactionID"].Value);
                t.AccountID = _user.AccountID;
                t.Description = row.Cells["colDescription"].Value.ToString();
                t.Date = DateTime.Now;
                t.Amount = amount;
                t.TransactionType = (TransactionType)Enum.Parse(typeof(TransactionType), row.Cells["colType"].Value.ToString());
                if (t.TransactionType == TransactionType.Expense)
                {
                    decimal originalAmount = 0;
                    foreach (Transaction existing in transactions)
                    {
                        if (existing.TransactionID == t.TransactionID)
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
                    if (t.Amount > remainingBudget)
                    {
                        MessageBox.Show("Insufficient budget! Your remaining budget is ₱" + remainingBudget.ToString("N0") + ". You cannot add this expense.", "Insufficient Budget");
                        return;
                    }
                }
                t.Category = (Category)Enum.Parse(typeof(Category),row.Cells["colCategory"].Value.ToString());

                transactionLogic.UpdateTransaction(t);
                LoadTransactions();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating: " + ex.Message);
            }
        }
        private void DeleteTransaction(int rowIndex)
        {
            var row = dgvTransaction.Rows[rowIndex];
            int transactionID = Convert.ToInt32(row.Cells["colTransactionID"].Value);

            DialogResult confirm = MessageBox.Show("Are you sure you want to delete this transaction?","Delete Transaction",MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                transactionLogic.DeleteTransaction(transactionID);
                LoadTransactions();
            }
        }
        private void CancelTransaction(int rowIndex)
        {
            var row = dgvTransaction.Rows[rowIndex];
            var idValue = row.Cells["colTransactionID"].Value;
            int transactionID = (idValue != null && idValue.ToString() != "")? Convert.ToInt32(idValue) : -1;

            if (transactionID == -1)
            {
                dgvTransaction.Rows.RemoveAt(rowIndex);
                _isAddingNew = false;
            }
            else
            {
                _isEditing = false;
                _editingRowIndex = -1;
                LoadTransactions();
            }
        }
        private void dgvTransaction_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            var row = dgvTransaction.Rows[e.RowIndex];

            var idValue = row.Cells["colTransactionID"].Value;
            int transactionID = (idValue != null && idValue.ToString() != "")? Convert.ToInt32(idValue) : -1;

            if (e.ColumnIndex == dgvTransaction.Columns["colSave"].Index)
            {
                if (transactionID == -1)
                {
                    SaveNewTransaction(e.RowIndex);
                }
                else
                {
                    if (_isEditing == true && _editingRowIndex == e.RowIndex)
                    {
                        SaveEditedTransaction(e.RowIndex);
                    }
                    else
                    {
                        EditTransaction(e.RowIndex);
                    }
                }
            }

            if (e.ColumnIndex == dgvTransaction.Columns["colDelete"].Index)
            {
                string deleteValue = row.Cells["colDelete"].Value?.ToString();
                if (deleteValue == "❌")
                {
                    CancelTransaction(e.RowIndex);
                }
                else
                {
                    DeleteTransaction(e.RowIndex);
                }
            }
        }
        private void dgvTransaction_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvTransaction.IsCurrentCellDirty)
            {
                dgvTransaction.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }
        private void dgvTransaction_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            if (e.ColumnIndex != dgvTransaction.Columns["colType"].Index)
            {
                return;
            }
            string selectedType = dgvTransaction.Rows[e.RowIndex].Cells["colType"].Value?.ToString();

            DataGridViewComboBoxCell categoryCell = (DataGridViewComboBoxCell)dgvTransaction.Rows[e.RowIndex].Cells["colCategory"];
            categoryCell.Items.Clear();

            if (selectedType == "Budget")
            {
                categoryCell.Items.Add("Allowance");
                categoryCell.Items.Add("Income");
                categoryCell.Items.Add("Others");
            }
            else if (selectedType == "Expense")
            {
                categoryCell.Items.Add("Food");
                categoryCell.Items.Add("Transportation");
                categoryCell.Items.Add("Utilities");
                categoryCell.Items.Add("Miscellaneous");
                categoryCell.Items.Add("Health");
                categoryCell.Items.Add("Leisure");
                categoryCell.Items.Add("Others");
            }
            categoryCell.Value = null;
        }
        private void cmbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadTransactions();
        }
        private void cmbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadTransactions();
        }
        private void btnAll_Click(object sender, EventArgs e)
        {
            DisplayTransactions(transactions);
        }
        private void btnExpense_Click(object sender, EventArgs e)
        {
            List<Transaction> filtered = transactionLogic.GetByType(transactions, TransactionType.Expense);
            DisplayTransactions(filtered);
        }
        private void btnBudget_Click(object sender, EventArgs e)
        {
            List<Transaction> filtered = transactionLogic.GetByType(transactions, TransactionType.Budget);
            DisplayTransactions(filtered);
        }
        private void SwitchPage(Form newPage) { _isNavigating = true; newPage.Show(); this.Hide(); }
        private void HomeButtonGoal_Click(object sender, EventArgs e) { _isNavigating = true; _home.Show(); this.Hide(); }
        private void GoalButtonGoal_Click(object sender, EventArgs e) => SwitchPage(new GoalForm(_home, _user));
        private void TranButtonGoal_Click(object sender, EventArgs e) { }
        private void SumButtonGoal_Click(object sender, EventArgs e) => SwitchPage(new SummaryForm(_home, _user));
        private void PredButtonGoal_Click(object sender, EventArgs e) => SwitchPage(new PredictionForm(_home, _user));
        private void LogoutButtonGoal_Click(object sender, EventArgs e) { _isNavigating = true; new LoginForms().Show(); this.Dispose(); }
        private void Transaction_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_isNavigating && e.CloseReason == CloseReason.UserClosing)
                Application.Exit();
        }
        private void lblDate_Click(object sender, EventArgs e) { }
        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void dgvTransaction_Click(object sender, EventArgs e) { }
        private void lblTransaction_Click(object sender, EventArgs e) { }
        private void pnlBudget_Paint(object sender, PaintEventArgs e) { }
        private void lblBudget_Click(object sender, EventArgs e) { }
        private void pnlTotalSpent_Paint(object sender, PaintEventArgs e) { }
        private void lblSpent_Click(object sender, EventArgs e) { }
        private void lblBudget2_Click_1(object sender, EventArgs e) { }
    }
}
