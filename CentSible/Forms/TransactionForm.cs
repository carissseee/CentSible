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

            cmbYear.SelectedIndexChanged -= cmbYear_SelectedIndexChanged;
            cmbYear.Items.Add(DateTime.Now.Year.ToString());
            cmbYear.SelectedIndex = 0;
            cmbYear.SelectedIndexChanged += cmbYear_SelectedIndexChanged;

            int currentMonth = DateTime.Now.Month;
            cmbMonth.SelectedIndexChanged -= cmbMonth_SelectedIndexChanged;
            for (int i = 1; i <= currentMonth; i++)
            {
                cmbMonth.Items.Add(new DateTime(2026, i, 1).ToString("MMMM"));
            }
            cmbMonth.SelectedIndex = DateTime.Now.Month - 1;
            cmbMonth.SelectedIndexChanged += cmbMonth_SelectedIndexChanged;

            LoadTransactions();
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
        private void lblBudget2_Click_1(object sender, EventArgs e) { }
    }
}
