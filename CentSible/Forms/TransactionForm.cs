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

            LoadTransactions();
        }
        private void LoadTransactions()
        {
            int month = cmbMonth.SelectedIndex + 1;
            int year = int.Parse(cmbYear.SelectedItem.ToString());

            transactions = transactionLogic.GetTransactions(_user.AccountID, month, year);

            lblBudget2.Text = "₱ " + transactionLogic.GetTotalBudget(transactions).ToString("N0");
            lblSpent2.Text = "₱ " + transactionLogic.GetTotalSpent(transactions).ToString("N0");
            lblRemaining2.Text = "₱ " + transactionLogic.GetRemainingBudget(transactions).ToString("N0");

            DisplayTransactions(transactions);
        }

        private void DisplayTransactions(List<Transaction> list)
        {
            dgvTransactions.Rows.Clear();

            foreach (var transaction in list)
            {
                string sign = transaction.TransactionType == TransactionType.Budget ? "+₱" : "-₱";

                dgvTransactions.Rows.Add(transaction.Date.ToString("MMM d"), transaction.Description, transaction.Category.ToString(), sign + transaction.Amount.ToString("N0"), " ");
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
            var filtered = transactionLogic.GetByType(transactions, TransactionType.Expense);
            DisplayTransactions(filtered);
        }

        private void btnBudget_Click(object sender, EventArgs e)
        {
            var filtered = transactionLogic.GetByType(transactions, TransactionType.Budget);
            DisplayTransactions(filtered);
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

        private void Switch(Form next) { _isNavigating = true; next.Show(); this.Close(); }
        private void HomeButtonGoal_Click(object sender, EventArgs e) { _isNavigating = true; _home.Show(); this.Close(); }
        private void GoalButtonGoal_Click(object sender, EventArgs e) => Switch(new GoalForm(_home, _user));
        private void TranButtonGoal_Click(object sender, EventArgs e) { }
        private void SumButtonGoal_Click(object sender, EventArgs e) => Switch(new SummaryForm(_home, _user));
        private void PredButtonGoal_Click(object sender, EventArgs e) => Switch(new PredictionForm(_home, _user));
        private void LogoutButtonGoal_Click(object sender, EventArgs e) { _isNavigating = true; new LoginForms().Show(); this.Dispose(); }

        private void TransactionForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_isNavigating && e.CloseReason == CloseReason.UserClosing) Application.Exit();
        }
    }
}
