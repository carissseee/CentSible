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
namespace CentSible.Views
{
    public partial class PredictionForm : Form
    {
        private Form _home;
        private Account _user;
        private bool _isNavigating = false;

        public PredictionForm()
        {
            InitializeComponent();
        }

        public PredictionForm(Form home, Account user)
        {
            InitializeComponent();
            _home = home;
            _user = user;
        }

        private void PredictionForm_Load(object sender, EventArgs e)
        {
            if (_user == null) return;

            btnNavPred.BackColor = Color.FromArgb(212, 236, 204);
            btnNavPred.ForeColor = Color.Black;
        }

        private void Switch(Form next) { _isNavigating = true; next.Show(); this.Hide(); }
        private void btnNavHome_Click(object sender, EventArgs e) { _isNavigating = true; _home.Show(); this.Hide(); }
        private void btnNavGoal_Click(object sender, EventArgs e) => Switch(new GoalForm(_home, _user));
        private void btnNavTrans_Click(object sender, EventArgs e) => Switch(new TransactionForm(_home, _user));
        private void btnNavPred_Click(object sender, EventArgs e) { }

        private void btnNavSum_Click(object sender, EventArgs e) => Switch(new SummaryForm(_home, _user));

        private void btnNavLogout_Click(object sender, EventArgs e)
        {
            new LoginForms().Show();
            this.Dispose();
        }
        private void PredictionForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_isNavigating && e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }
    }
}