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
using System;
using System.Drawing;
using System.Windows.Forms;
using CentSible.Models;

namespace CentSible.Forms
{
    public partial class TransactionForm : Form
    {
        private Form _home;
        private Account _user;
        private bool _isNavigating = false;

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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblDate_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
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
    }
}