using CentSible.Logic;
using CentSible.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            if (_user == null) return;
            TranButtonGoal.BackColor = Color.FromArgb(212, 236, 204);
            TranButtonGoal.ForeColor = Color.Black;

            int currentYear = DateTime.Now.Year;
            for (int i = currentYear; i >= currentYear - 5; i--)
            {
                cmbYear.Items.Add(i.ToString());
            }
            cmbYear.SelectedIndex = 0;

            for (int i = 1; i <= 12; i++)
            {
                cmbMonth.Items.Add(new DateTime(2000, i, 1).ToString("MMMM"));
            }   
            cmbMonth.SelectedIndex = DateTime.Now.Month - 1;

            colEdit.Text = "✏️";
            colEdit.UseColumnTextForButtonValue = true;
            colDelete.Text = "❌";
            colDelete.UseColumnTextForButtonValue = true;

            dgvTransaction.CellClick += dgvTransaction_CellClick;
            DataGridViewComboBoxColumn categorycol = (DataGridViewComboBoxColumn)dgvTransaction.Columns["colcategory"];
            categorycol.Items.Clear();
            categorycol.Items.Add("allowance");
            categorycol.Items.Add("income");
            categorycol.Items.Add("others");
            categorycol.Items.Add("food");
            categorycol.Items.Add("transportation");
            categorycol.Items.Add("utilities");
            categorycol.Items.Add("miscellaneous");
            categorycol.Items.Add("health");
            categorycol.Items.Add("leisure");
            dgvTransaction.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;

            LoadTransactions();
        }

        private void LoadTransactions()
        {
            dgvTransaction.Rows.Clear();
            _isAddingNew = false;

            int month = cmbMonth.SelectedIndex + 1;
            int year = int.Parse(cmbYear.SelectedItem.ToString());

            transactions = transactionLogic.GetTransactions(_user.AccountID, month, year);

            lblBudget2.Text = "₱ " + transactionLogic.GetTotalBudget(transactions).ToString("N0");
            lblSpent2.Text = "₱ " + transactionLogic.GetTotalSpent(transactions).ToString("N0");
            lblRemaining2.Text = "₱ " + transactionLogic.GetRemainingBudget(transactions).ToString("N0");

            foreach (var t in transactions)
            {
                string sign = t.TransactionType == TransactionType.Budget ? "+₱" : "-₱";
                dgvTransaction.Rows.Add(
                    t.Date.ToString("MMM d"),
                    t.Description,
                    t.Category.ToString(),
                    t.TransactionType.ToString(),
                    sign + t.Amount.ToString("N0"),
                    "✏️", 
                    "❌", 
                    t.TransactionID  
                );
            }
        }

        private void DisplayTransactions(List<Transaction> list)
        {
            dgvTransaction.Rows.Clear();

            foreach (var t in list)
            {
                string sign = t.TransactionType == TransactionType.Budget ? "+₱" : "-₱";
                dgvTransaction.Rows.Add(
                    t.Date.ToString("MMM d"),
                    t.Description,
                    t.Category.ToString(),
                    t.TransactionType.ToString(),
                    sign + t.Amount.ToString("N0"),
                    "", 
                    "",  
                    t.TransactionID 
                );
            }
        }
        private void btnAddTransaction_Click(object sender, EventArgs e)
        {
            if (_isAddingNew)
            {
                MessageBox.Show("Please save or cancel the current new transaction first!");
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
        private void dgvTransaction_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = dgvTransaction.Rows[e.RowIndex];
            var idValue = row.Cells["colTransactionID"].Value;
            int transactionID = (idValue != null && idValue.ToString() != "") ? Convert.ToInt32(idValue) : -1;

         
            if (e.ColumnIndex == dgvTransaction.Columns["colEdit"].Index)
            {
                if (transactionID == -1)
                {
                    SaveNewTransaction(e.RowIndex);
                }
                else
                {
                    var editCell = dgvTransaction.Rows[e.RowIndex].Cells["colEdit"];
                    if (editCell.Value?.ToString() == "💾")
                        SaveEditedTransaction(e.RowIndex);
                    else
                        EditTransaction(e.RowIndex);
                }
            }

            if (e.ColumnIndex == dgvTransaction.Columns["colDelete"].Index)
            {
                if (transactionID == -1)
                {
                    dgvTransaction.Rows.RemoveAt(e.RowIndex);
                    _isAddingNew = false;
                }
                else
                {
                    var confirm = MessageBox.Show("Are you sure you want to delete this transaction?", "Delete", MessageBoxButtons.YesNo);
                    if (confirm == DialogResult.Yes)
                    {
                        transactionLogic.DeleteTransaction(transactionID);
                        LoadTransactions();
                    }
                }
            }
        }
        private void SaveNewTransaction(int rowIndex)
        {
            try
            {
                var row = dgvTransaction.Rows[rowIndex];

                Transaction t = new Transaction();
                t.AccountID = _user.AccountID;
                t.Description = row.Cells["colDescription"].Value?.ToString();
                t.Amount = decimal.Parse(row.Cells["colAmount"].Value?.ToString());
                t.Date = DateTime.Now;

                
                string typeValue = row.Cells["colType"].Value?.ToString();
                t.TransactionType = (TransactionType)Enum.Parse(typeof(TransactionType), typeValue);

                
                string categoryValue = row.Cells["colCategory"].Value?.ToString();
                t.Category = (Category)Enum.Parse(typeof(Category), categoryValue);

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
            dgvTransaction.Rows[rowIndex].Cells["colEdit"].Value = "💾";
            dgvTransaction.CurrentCell = dgvTransaction.Rows[rowIndex].Cells["colDescription"];
            dgvTransaction.BeginEdit(true);
        }

        private void SaveEditedTransaction(int rowIndex)
        {
            try
            {
                var row = dgvTransaction.Rows[rowIndex];

                Transaction t = new Transaction();
                t.TransactionID = Convert.ToInt32(row.Cells["colTransactionID"].Value);
                t.AccountID = _user.AccountID;
                t.Description = row.Cells["colDescription"].Value?.ToString();
                t.Amount = decimal.Parse(row.Cells["colAmount"].Value?.ToString().Replace("₱", "").Replace("+", "").Replace("-", "").Trim());
                t.Date = DateTime.Now;

                string typeValue = row.Cells["colType"].Value?.ToString();
                t.TransactionType = (TransactionType)Enum.Parse(typeof(TransactionType), typeValue);

                string categoryValue = row.Cells["colCategory"].Value?.ToString();
                t.Category = (Category)Enum.Parse(typeof(Category), categoryValue);

                transactionLogic.UpdateTransaction(t);
                LoadTransactions();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating: " + ex.Message);
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

        private void Switch(Form next) 
        { 
            _isNavigating = true; next.Show(); this.Close(); 
        }
        private void HomeButtonGoal_Click(object sender, EventArgs e) 
        { 
            _isNavigating = true; _home.Show(); this.Close(); 
        }
        private void GoalButtonGoal_Click(object sender, EventArgs e) => Switch(new GoalForm(_home, _user));
        private void TranButtonGoal_Click(object sender, EventArgs e) => Switch(new TransactionForm(_home, _user));
        private void SumButtonGoal_Click(object sender, EventArgs e) => Switch(new SummaryForm(_home, _user));
        private void PredButtonGoal_Click(object sender, EventArgs e) => Switch(new PredictionForm(_home, _user));
        private void LogoutButtonGoal_Click(object sender, EventArgs e) 
        { 
            _isNavigating = true; 
            new LoginForms().Show(); 
            this.Dispose(); 
        }

        private void TransactionForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_isNavigating && e.CloseReason == CloseReason.UserClosing) Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e) 
        { 
        }
        private void lblDate_Click(object sender, EventArgs e) 
        { 
        }
        private void panel1_Paint(object sender, PaintEventArgs e) 
        { 
        }
        private void lblBudget2_Click(object sender, EventArgs e) 
        { 
        }
        private void button1_Click(object sender, EventArgs e) 
        { 
        }
        private void dgvTransaction_Click(object sender, EventArgs e) 
        { 
        }
        private void lblTransaction_Click(object sender, EventArgs e) 
        { 
        }
        private void pnlBudget_Paint(object sender, PaintEventArgs e) 
        { 
        }
        private void lblBudget_Click(object sender, EventArgs e)
        { 
        }
        private void pnlTotalSpent_Paint(object sender, PaintEventArgs e) 
        { 
        }
        private void lblSpent_Click(object sender, EventArgs e) 
        { 
        }
        private void lblBudget2_Click_1(object sender, EventArgs e) 
        { 
        }
    }
}