using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CentSible.Models;
namespace CentSible.Forms
{
    public partial class PredictionForm : Form
    {
        private Form _home;
        private Account _user;
        private bool _isNavigating = false;

        public PredictionForm(Form home, Account user)
        {
            InitializeComponent();
            _home = home;
            _user = user;
        }

       
        private void PredictionForm_Load(object sender, EventArgs e)
        {
            if (_user == null) return;

            PredButtonGoal.BackColor = Color.FromArgb(212, 236, 204);
            PredButtonGoal.ForeColor = Color.Black;
        }

        private void SwitchPage(Form newPage) { _isNavigating = true; newPage.Show(); this.Hide(); }
        private void HomeButtonGoal_Click(object sender, EventArgs e) { _isNavigating = true; _home.Show(); this.Close(); }      
        private void GoalButtonGoal_Click(object sender, EventArgs e) => SwitchPage(new GoalForm(_home, _user));
        private void TranButtonGoal_Click(object sender, EventArgs e) => SwitchPage(new TransactionForm(_home, _user));
        private void SumButtonGoal_Click(object sender, EventArgs e) => SwitchPage(new SummaryForm(_home, _user));
        private void PredButtonGoal_Click(object sender, EventArgs e) { }     
        private void LogoutButtonGoal_Click(object sender, EventArgs e) { _isNavigating = true; new LoginForms().Show(); this.Dispose(); }
        private void PredictionForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_isNavigating && e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }
    }
}