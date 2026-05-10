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

            UIHelper.WireClickRecursive(HomeTabLayTran, HomeButtonTran_Click);
            UIHelper.WireClickRecursive(GoalTabLayTran, GoalButtonTran_Click);
            UIHelper.WireClickRecursive(SumTabLayTran, SumButtonTran_Click);
            UIHelper.WireClickRecursive(PredTabLayTran, PredButtonTran_Click);
        }
        private void TransactionForm_Load(object sender, EventArgs e)
        {
            if (_user == null)
            {
                return;
            }

            TranButtonTran.BackColor = Color.FromArgb(212, 236, 204);
            TranButtonTran.ForeColor = Color.Black;

            cmbYearTran.Items.Add(DateTime.Now.Year.ToString());
            cmbYearTran.SelectedIndex = 0;

            int currentMonth = DateTime.Now.Month;
            for (int i = 1; i <= currentMonth; i++)
            {
                cmbMonthTran.Items.Add(new DateTime(2000, i, 1).ToString("MMMM"));
            }
            cmbMonthTran.SelectedIndex = currentMonth - 1;

            dgvTransaction.DataError += (s, ex) => { ex.Cancel = true; };

            LoadTransactions();
        }
        private void SetFilterButtons(bool enabled)
        {
            btnAll.Enabled = enabled;
            btnExpense.Enabled = enabled;
            btnBudget.Enabled = enabled;
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

            lblDateTran.Text = new DateTime(year, month, 1).ToString("MMMM yyyy");

            transactions = transactionLogic.GetTransactions(_user.AccountID, month, year);
            lblBudget2.Text = "₱ " + transactionLogic.GetTotalBudget(transactions).ToString("N2");
            lblSpent2.Text = "₱ " + transactionLogic.GetTotalSpent(transactions).ToString("N2");
            lblRemaining2.Text = "₱ " + transactionLogic.GetRemainingBudget(transactions).ToString("N2");

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
        private void dgvTransaction_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            var row = dgvTransaction.Rows[e.RowIndex];
            var idValue = row.Cells["colTransactionID"].Value;
            int transactionID = (idValue != null && idValue.ToString() != "") ? Convert.ToInt32(idValue) : -1;
            int month = cmbMonthTran.SelectedIndex + 1;
            int year = int.Parse(cmbYearTran.SelectedItem.ToString());

            if (e.ColumnIndex == dgvTransaction.Columns["colSave"].Index)
            {
                if (transactionID == -1)
                {
                    string error = transactionLogic.AddNewTransaction(_user.AccountID,
                        row.Cells["colDescription"].Value?.ToString(),
                        row.Cells["colType"].Value?.ToString(),
                        row.Cells["colCategory"].Value?.ToString(),
                        row.Cells["colAmount"].Value?.ToString(),
                        transactions
                    );

                    if (error != "")
                    {
                        MessageBox.Show(error);
                        return;
                    }

                    LoadTransactions();
                }
                else
                {
                    if (_isEditing == true && _editingRowIndex == e.RowIndex)
                    {
                        string error = transactionLogic.UpdateExistingTransaction(_user.AccountID,
                            transactionID,
                            row.Cells["colDescription"].Value?.ToString(),
                            row.Cells["colType"].Value?.ToString(),
                            row.Cells["colCategory"].Value?.ToString(),
                            row.Cells["colAmount"].Value?.ToString(),
                            month,
                            year
                        );

                        if (error != "")
                        {
                            MessageBox.Show(error);
                            return;
                        }

                        LoadTransactions();
                    }
                    else
                    {
                        _isEditing = true;
                        _editingRowIndex = e.RowIndex;
                        SetFilterButtons(false);

                        string rawAmount = row.Cells["colAmount"].Value?.ToString()
                            .Replace("+₱", "")
                            .Replace("-₱", "")
                            .Replace(",", "")
                            .Trim();
                        row.Cells["colAmount"].Value = rawAmount;
                        row.Cells["colDelete"].Value = "❌";

                        dgvTransaction.CurrentCell = dgvTransaction.Rows[e.RowIndex].Cells["colDescription"];
                        dgvTransaction.BeginEdit(true);
                    }
                }
            }

            if (e.ColumnIndex == dgvTransaction.Columns["colDelete"].Index)
            {
                string deleteValue = row.Cells["colDelete"].Value?.ToString();

                if (deleteValue == "❌")
                {
                    if (transactionID == -1)
                    {
                        dgvTransaction.Rows.RemoveAt(e.RowIndex);
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
                else
                {
                    DialogResult confirm = MessageBox.Show("Are you sure you want to delete this transaction?", "Delete Transaction", MessageBoxButtons.YesNo);

                    if (confirm == DialogResult.Yes)
                    {
                        transactionLogic.DeleteTransaction(transactionID);
                        LoadTransactions();
                    }
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
        private void cmbYearTran_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadTransactions();
        }
        private void cmbMonthTran_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadTransactions();
        }
        private void btnAll_Click(object sender, EventArgs e)
        {
            DisplayTransactions(transactions);
        }
        private void btnExpense_Click(object sender, EventArgs e)
        {
            DisplayTransactions(transactionLogic.GetByType(transactions, TransactionType.Expense));
        }
        private void btnBudget_Click(object sender, EventArgs e)
        {
            DisplayTransactions(transactionLogic.GetByType(transactions, TransactionType.Budget));
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
    }
}
