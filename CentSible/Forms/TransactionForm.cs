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
    public partial class TransactionForm : BaseNavForm
    {
        private bool _isAddingNew = false;
        private bool _isEditing = false;
        private int _editingRowIndex = -1;
        private TransactionLogic transactionLogic = new TransactionLogic();
        private List<Transaction> transactions = new List<Transaction>();
        public TransactionForm(Account user) : base(user)
       
        {
            InitializeComponent();
            InitializeNavigation();      
        }

        protected override void InitializeNavigation()
        {
            var homeGroup = new Control[] { HomeButtonTran, HomeTabLayTran };
            var goalGroup = new Control[] { GoalButtonTran, GoalTabLayTran };
            var sumGroup = new Control[] { SumButtonTran, SumTabLayTran };
            var predGroup = new Control[] { PredButtonTran, PredTabLayTran };
            var logGroup = new Control[] { LogoutBtnTran, LogTabLayTran };

            UIHelper.WireHoverRecursive(HomeButtonTran, homeGroup);
            UIHelper.WireHoverRecursive(GoalButtonTran, goalGroup);
            UIHelper.WireHoverRecursive(SumButtonTran, sumGroup);
            UIHelper.WireHoverRecursive(PredButtonTran, predGroup);
            UIHelper.WireHoverRecursive(LogoutBtnTran, logGroup);

            UIHelper.WireClickRecursive(HomeTabLayTran, (s, e) => PerformNavigation(() => Navigator.SwitchTo(this, Navigator.Home)));
            UIHelper.WireClickRecursive(GoalTabLayTran, (s, e) => PerformNavigation(() => Navigator.SwitchTo(this, Navigator.Goal)));
            UIHelper.WireClickRecursive(SumTabLayTran, (s, e) => PerformNavigation(() => Navigator.SwitchTo(this, Navigator.Summary)));
            UIHelper.WireClickRecursive(PredTabLayTran, (s, e) => PerformNavigation(() => Navigator.SwitchTo(this, Navigator.Prediction)));
            UIHelper.WireClickRecursive(LogTabLayTran, (s, e) => Navigator.Logout(this));
        }
        private void TransactionForm_Load(object sender, EventArgs e)
        {
            if (_user == null) return;


            TranButtonTran.BackColor = Color.FromArgb(52, 110, 60);
            TranButtonTran.ForeColor = Color.Black;

            
            if (dgvTransaction.Columns["colType"] is DataGridViewComboBoxColumn typeCol)
            {
                typeCol.Items.Clear();
                typeCol.Items.Add("Expense");
                typeCol.Items.Add("Budget");
            }

            cmbYearTran.SelectedIndexChanged -= cmbYear_SelectedIndexChanged;
            cmbMonthTran.SelectedIndexChanged -= cmbMonthTran_SelectedIndexChanged;    
            cmbYearTran.Items.Clear();
            cmbYearTran.Items.Add(DateTime.Now.Year.ToString());
            cmbYearTran.SelectedIndex = 0;

         
            int currentMonth = DateTime.Now.Month;
            cmbMonthTran.Items.Clear();
            for (int i = 1; i <= currentMonth; i++)
            {
                cmbMonthTran.Items.Add(new DateTime(2000, i, 1).ToString("MMMM"));
            }
            cmbMonthTran.SelectedIndex = currentMonth - 1;       
            dgvTransaction.DataError += (s, ex) => { ex.Cancel = true; };
            cmbYearTran.SelectedIndexChanged += cmbYear_SelectedIndexChanged;
            cmbMonthTran.SelectedIndexChanged += cmbMonthTran_SelectedIndexChanged;

            dgvTransaction.ReadOnly = true;
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

         
            DisplayTransactions(transactions);
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


                int rowIndex = dgvTransaction.Rows.Add(
                    t.Date.ToString("MMM d"),
                    t.Description,
                    t.TransactionType.ToString(),
                    null,
                    sign + t.Amount.ToString("N2"),
                    "💾",
                    "🗑️",
                    t.TransactionID
                );

                var row = dgvTransaction.Rows[rowIndex];
                row.ReadOnly = true;
                if (row.Cells["colCategory"] is DataGridViewComboBoxCell categoryCell)
                {
                    
                    categoryCell.Items.Clear();

                    
                    if (t.TransactionType == TransactionType.Budget)
                    {
                        categoryCell.Items.AddRange(new[] { "Allowance", "Income", "Others" });
                    }
                    else
                    {
                        categoryCell.Items.AddRange(new[] { "Food", "Transportation", "Utilities", "Health", "Leisure", "Others" });
                    }

                    
                    categoryCell.Value = t.Category.ToString();
                }
            }
        }

        private void dgvTransaction_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dgvTransaction.Rows[e.RowIndex];
            var idValue = row.Cells["colTransactionID"].Value;
            int transactionID = (idValue != null && idValue.ToString() != "") ? Convert.ToInt32(idValue) : -1;

            if (e.ColumnIndex == dgvTransaction.Columns["colSave"].Index)
            {
                if (transactionID == -1)
                    SaveNewTransaction(e.RowIndex);
                else if (_isEditing && _editingRowIndex == e.RowIndex)
                    SaveEditedTransaction(e.RowIndex);
                else
                    EditTransaction(e.RowIndex);
            }

            if (e.ColumnIndex == dgvTransaction.Columns["colDelete"].Index)
            {
                string deleteValue = row.Cells["colDelete"].Value?.ToString();
                if (deleteValue == "❌")
                    CancelTransaction(e.RowIndex);
                else
                    DeleteTransaction(e.RowIndex);
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
           
            if (e.RowIndex < 0 || e.ColumnIndex != dgvTransaction.Columns["colType"].Index)
            {
                return;
            }

           
            var row = dgvTransaction.Rows[e.RowIndex];
            string selectedType = row.Cells["colType"].Value?.ToString();

            if (row.Cells["colCategory"] is DataGridViewComboBoxCell categoryCell)
            {
                
                string[] targetCategories;
                if (selectedType == "Budget")
                {
                    targetCategories = new[] { "Allowance", "Income", "Others" };
                }
                else if (selectedType == "Expense")
                {
                    targetCategories = new[] { "Food", "Transportation", "Utilities", "Health", "Leisure", "Others" };
                }
                else
                {
                    categoryCell.Items.Clear();
                    return;
                }

               
                if (categoryCell.Items.Count != targetCategories.Length)
                {
                    categoryCell.Items.Clear();
                    categoryCell.Items.AddRange(targetCategories);

                   
                    categoryCell.Value = null;
                }
            }
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

            dgvTransaction.ReadOnly = false;
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
            dgvTransaction.Rows[newRowIndex].ReadOnly = false;
            dgvTransaction.CurrentCell = dgvTransaction.Rows[newRowIndex].Cells["colDescription"];
            dgvTransaction.BeginEdit(true);
        }

        private void SaveNewTransaction(int rowIndex)
        {
            var row = dgvTransaction.Rows[rowIndex];

            string error = transactionLogic.AddNewTransaction(
                _user.AccountID,
                row.Cells["colDescription"].Value?.ToString(),
                row.Cells["colType"].Value?.ToString(),
                row.Cells["colCategory"].Value?.ToString(),
                row.Cells["colAmount"].Value?.ToString(),
                transactions
            );

            if (error != "") { MessageBox.Show(error); return; }
            LoadTransactions();
        }

        private void SaveEditedTransaction(int rowIndex)
        {
            var row = dgvTransaction.Rows[rowIndex];
            int transactionID = Convert.ToInt32(row.Cells["colTransactionID"].Value);
            int month = cmbMonthTran.SelectedIndex + 1;
            int year = int.Parse(cmbYearTran.SelectedItem.ToString());

            string error = transactionLogic.UpdateExistingTransaction(
                _user.AccountID,
                transactionID,
                row.Cells["colDescription"].Value?.ToString(),
                row.Cells["colType"].Value?.ToString(),
                row.Cells["colCategory"].Value?.ToString(),
                row.Cells["colAmount"].Value?.ToString(),
                month,
                year
            );

            if (error != "") { MessageBox.Show(error); return; }
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

            dgvTransaction.ReadOnly = false;
            dgvTransaction.Rows[rowIndex].ReadOnly = false;
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
        private void cmbMonthTran_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadTransactions();
        }
        private void AllBtnTran_Click(object sender, EventArgs e)
        {
            DisplayTransactions(transactions);
        }
        private void ExpenseBtnTran_Click(object sender, EventArgs e)
        {
            DisplayTransactions(transactionLogic.GetByType(transactions, TransactionType.Expense));
        }
        private void BudgetBtnTran_Click(object sender, EventArgs e)
        {
            DisplayTransactions(transactionLogic.GetByType(transactions, TransactionType.Budget));
        }
        private void HomeButtonTran_Click(object sender, EventArgs e) => Navigator.SwitchTo(this, Navigator.Home);
        private void GoalButtonTran_Click(object sender, EventArgs e) => Navigator.SwitchTo(this, Navigator.Goal);
        private void SumButtonTran_Click(object sender, EventArgs e) => Navigator.SwitchTo(this, Navigator.Summary);
        private void PredButtonTran_Click(object sender, EventArgs e) => Navigator.SwitchTo(this, Navigator.Prediction);
        private void LogoutButtonTran_Click(object sender, EventArgs e) => Navigator.Logout(this);
       
        private void AddTransactionBtnTran_Click(object sender, EventArgs e)
        {
            AddTransaction(sender, e);
        }
    }
}


