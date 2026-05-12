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
        public TransactionForm(Account user)
        {
            InitializeComponent(); 
        
            _user = user;

            var homeGroup = new Control[] { HomeButtonTran, HomeTabLayTran };
            UIHelper.WireHoverRecursive(HomeButtonTran, homeGroup);
            UIHelper.WireHoverRecursive(HomeTabLayTran, homeGroup);

            var goalGroup = new Control[] { GoalButtonTran, GoalTabLayTran };
            UIHelper.WireHoverRecursive(GoalButtonTran, goalGroup);
            UIHelper.WireHoverRecursive(GoalTabLayTran, goalGroup);

            var sumGroup = new Control[] { SumButtonTran, SumTabLayTran };
            UIHelper.WireHoverRecursive(SumButtonTran, sumGroup);
            UIHelper.WireHoverRecursive(SumTabLayTran, sumGroup);

            var predGroup = new Control[] { PredButtonTran, PredTabLayTran };
            UIHelper.WireHoverRecursive(PredButtonTran, predGroup);
            UIHelper.WireHoverRecursive(PredTabLayTran, predGroup);

            var logGroup = new Control[] { LogoutBtnTran, LogTabLayTran };
            UIHelper.WireHoverRecursive(LogoutBtnTran, logGroup);
            UIHelper.WireHoverRecursive(LogTabLayTran, logGroup);

            UIHelper.WireClickRecursive(HomeTabLayTran, HomeButtonTran_Click);
            UIHelper.WireClickRecursive(GoalTabLayTran, GoalButtonTran_Click);
            UIHelper.WireClickRecursive(SumTabLayTran, SumButtonTran_Click);
            UIHelper.WireClickRecursive(PredTabLayTran, PredButtonTran_Click);
            UIHelper.WireClickRecursive(LogTabLayTran, LogoutButtonTran_Click);
        }
        private void TransactionForm_Load(object sender, EventArgs e)
        {
            if (_user == null)
            {
                return;
            }

            TranButtonTran.BackColor = Color.FromArgb(52, 110, 60);
            TranButtonTran.ForeColor = Color.Black;
            dgvTransaction.DataError += (s, ex) => { ex.Cancel = true; };

            cmbYearTran.SelectedIndexChanged -= cmbYear_SelectedIndexChanged;
            cmbYearTran.Items.Add(DateTime.Now.Year.ToString());
            cmbYearTran.SelectedIndex = 0;
            cmbYearTran.SelectedIndexChanged += cmbYear_SelectedIndexChanged;

            int currentMonth = DateTime.Now.Month;
            cmbMonthTran.SelectedIndexChanged -= cmbMonth_SelectedIndexChanged;
            for (int i = 1; i <= currentMonth; i++)
            {
                cmbMonthTran.Items.Add(new DateTime(2026, i, 1).ToString("MMMM"));
            }
            cmbMonthTran.SelectedIndex = DateTime.Now.Month - 1;
            cmbMonthTran.SelectedIndexChanged += cmbMonth_SelectedIndexChanged;

            LoadTransactions();
        }

        private void SetFilterButtons(bool enabled)
        {
            AllBtnTran.Enabled = enabled;
            ExpenseBtnTran.Enabled = enabled;
            BudgetBtnTran.Enabled = enabled;
        }

        private void LoadTransactions()
        {
            if (cmbMonthTran.SelectedIndex < 0 || cmbYearTran.SelectedItem == null)
            {
                return;
            }

            dgvTransaction.Rows.Clear();
            _isAddingNew = false;
            _isEditing = false;
            _editingRowIndex = -1;
            SetFilterButtons(true);

            int month = cmbMonthTran.SelectedIndex + 1;
            int year = int.Parse(cmbYearTran.SelectedItem.ToString());

            CurrentDateTran.Text = new DateTime(year, month, 1).ToString("MMMM yyyy");

            transactions = transactionLogic.GetTransactions(_user.AccountID, month, year);
            PBudgetLblTran.Text = "₱ " + transactionLogic.GetTotalBudget(transactions).ToString("N2");
            PSpentLblTran.Text = "₱ " + transactionLogic.GetTotalSpent(transactions).ToString("N2");
            PRemainingLblTran.Text = "₱ " + transactionLogic.GetRemainingBudget(transactions).ToString("N2");

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
                    sign + t.Amount.ToString("N2"),
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
                    sign + t.Amount.ToString("N2"),
                    "💾",
                    "🗑️",
                    t.TransactionID
                );
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
                categoryCell.Items.Add("Health");
                categoryCell.Items.Add("Leisure");
                categoryCell.Items.Add("Others");
            }
            categoryCell.Value = null;
        }

        private void AddTransaction(object sender, EventArgs e)
        {
            if (_isAddingNew)
            {
                MessageBox.Show("Please save the current new transaction first.");
                return;
            }
            if (_isEditing)
            {
                MessageBox.Show("Please save the current edited transaction first.");
                return;
            }

            _isAddingNew = true;
            SetFilterButtons(false);

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
            var row = dgvTransaction.Rows[rowIndex];

            string description = row.Cells["colDescription"].Value?.ToString();
            string type = row.Cells["colType"].Value?.ToString();
            string category = row.Cells["colCategory"].Value?.ToString();
            string amountStr = row.Cells["colAmount"].Value?.ToString();

            if (string.IsNullOrWhiteSpace(description) || string.IsNullOrWhiteSpace(type) ||
                string.IsNullOrWhiteSpace(category) || string.IsNullOrWhiteSpace(amountStr))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            if (!decimal.TryParse(amountStr, out decimal amount) || amount <= 0)
            {
                MessageBox.Show("Please enter a valid amount.");
                return;
            }

            Transaction t = new Transaction
            {
                AccountID = _user.AccountID,
                Date = DateTime.Now,
                Description = description,
                TransactionType = (TransactionType)Enum.Parse(typeof(TransactionType), type),
                Category = (Category)Enum.Parse(typeof(Category), category),
                Amount = amount
            };

            transactionLogic.AddTransaction(t);
            LoadTransactions();
        }

        private void SaveEditedTransaction(int rowIndex)
        {
            var row = dgvTransaction.Rows[rowIndex];
            int transactionID = Convert.ToInt32(row.Cells["colTransactionID"].Value);

            string description = row.Cells["colDescription"].Value?.ToString();
            string type = row.Cells["colType"].Value?.ToString();
            string category = row.Cells["colCategory"].Value?.ToString();
            string amountStr = row.Cells["colAmount"].Value?.ToString();

            if (string.IsNullOrWhiteSpace(description) || string.IsNullOrWhiteSpace(type) ||
                string.IsNullOrWhiteSpace(category) || string.IsNullOrWhiteSpace(amountStr))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            if (!decimal.TryParse(amountStr, out decimal amount) || amount <= 0)
            {
                MessageBox.Show("Please enter a valid amount.");
                return;
            }

            Transaction t = new Transaction
            {
                TransactionID = transactionID,
                AccountID = _user.AccountID,
                Date = DateTime.Now,
                Description = description,
                TransactionType = (TransactionType)Enum.Parse(typeof(TransactionType), type),
                Category = (Category)Enum.Parse(typeof(Category), category),
                Amount = amount
            };

            transactionLogic.UpdateTransaction(t);
            LoadTransactions();
        }
        private void EditTransaction(int rowIndex)
        {
            if (_isAddingNew)
            {
                MessageBox.Show("Please save the current new transaction first.");
                return;
            }
            if (_isEditing)
            {
                MessageBox.Show("Please save the current edited transaction first.");
                return;
            }

            _isEditing = true;
            _editingRowIndex = rowIndex;
            SetFilterButtons(false);

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

        private void CancelTransaction(int rowIndex)
        {
            var idValue = dgvTransaction.Rows[rowIndex].Cells["colTransactionID"].Value;
            int transactionID = (idValue != null && idValue.ToString() != "") ? Convert.ToInt32(idValue) : -1;

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

            SetFilterButtons(true);
        }

        private void DeleteTransaction(int rowIndex)
        {
            var idValue = dgvTransaction.Rows[rowIndex].Cells["colTransactionID"].Value;
            int transactionID = Convert.ToInt32(idValue);

            DialogResult confirm = MessageBox.Show(
                "Are you sure you want to delete this transaction?",
                "Delete Transaction",
                MessageBoxButtons.YesNo
            );

            if (confirm == DialogResult.Yes)
            {
                transactionLogic.DeleteTransaction(transactionID);
                LoadTransactions();
            }
        }
        private void cmbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadTransactions();
        }
        private void cmbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadTransactions();
        }
        private void AllBtnTran_Click(object sender, EventArgs e)
        {
            DisplayTransactions(transactions);
        }
        private void ExpenseBtnTran_Click(object sender, EventArgs e)
        {
            List<Transaction> filtered = transactionLogic.GetByType(transactions, TransactionType.Expense);
            DisplayTransactions(filtered);
        }
        private void BudgetBtnTran_Click(object sender, EventArgs e)
        {
            List<Transaction> filtered = transactionLogic.GetByType(transactions, TransactionType.Budget);
            DisplayTransactions(filtered);
        }
        private void HomeButtonTran_Click(object sender, EventArgs e) => Navigator.SwitchTo(this, Navigator.Home);
        private void GoalButtonTran_Click(object sender, EventArgs e) => Navigator.SwitchTo(this, Navigator.Goal);
        private void SumButtonTran_Click(object sender, EventArgs e) => Navigator.SwitchTo(this, Navigator.Summary);
        private void PredButtonTran_Click(object sender, EventArgs e) => Navigator.SwitchTo(this, Navigator.Prediction);
        private void LogoutButtonTran_Click(object sender, EventArgs e) => Navigator.Logout(this);
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
        private void PBudgetLblTran_Click_1(object sender, EventArgs e) { }

        private void SpenPanTran_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddTransactionBtnTran_Click(object sender, EventArgs e)
        {
            AddTransaction(sender, e);
        }
    }
}
