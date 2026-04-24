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
using CentSible.Logic;

namespace CentSible.Views
{
    public partial class HomeForm : Form
    {
        private Account _user;
        private bool _isNavigating = false;
        private GoalLogic _goalLogic;
        private AccountLogic _accountLogic = new AccountLogic();

        public HomeForm(Account user)
        {
            InitializeComponent();
            _user = user;
            _goalLogic = new GoalLogic();
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            if (_user == null) return;
            lblCurrentStreak.Text = _user.LoginStreak.ToString();
            UpdateHomeDashboard();
            UpdateWeeklyActivity();
            UpdateMilestoneProgress();
        }

        private void HomeForm_Activated(object sender, EventArgs e)
        {
            if (_user == null) return;
            lblCurrentStreak.Text = _user.LoginStreak.ToString();
            UpdateHomeDashboard();
            UpdateMilestoneProgress();
            UpdateWeeklyActivity();
            this.ActiveControl = null;
            this.Refresh();
        }

        private void HomeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_isNavigating && e.CloseReason == CloseReason.UserClosing) Application.Exit();
        }

        private void UpdateHomeDashboard()
        {
            var goals = _goalLogic.GetGoals(_user.AccountID, DateTime.Now.Month, DateTime.Now.Year);
            string month = DateTime.Now.ToString("MMMM");

            pbSpendingHome.Value = 0;
            pbSavingHome.Value = 0;
            lblSpendingStatus.Text = $"No spending goal set for {month}";
            lblSavingStatus.Text = $"No savings goal set for {month}";

            foreach (var goal in goals)
            {
                int percent = (int)Math.Min((goal.CurrentAmount / goal.TargetAmount) * 100, 100);
                string display = $"₱ {goal.CurrentAmount:N0} / ₱ {goal.TargetAmount:N0}";

                if (goal.GoalType == GoalCategory.Spending)
                {
                    pbSpendingHome.Value = percent;
                    lblSpendingStatus.Text = display;
                }
                else if (goal.GoalType == GoalCategory.Savings)
                {
                    pbSavingHome.Value = percent;
                    lblSavingStatus.Text = display;
                }
            }
        }

        private void UpdateWeeklyActivity()
        {
            Panel[] dayPanels = { pnlMon, pnlTue, pnlWed, pnlThu, pnlFri, pnlSat, pnlSun };
            DateTime today = DateTime.Today;
            int diff = (7 + (today.DayOfWeek - DayOfWeek.Monday)) % 7;
            DateTime startOfWeek = today.AddDays(-diff).Date;

            for (int i = 0; i < 7; i++)
            {
                DateTime target = startOfWeek.AddDays(i).Date;
                if (target == today) dayPanels[i].BackColor = Color.OrangeRed;
                else if (target < today) dayPanels[i].BackColor = Color.DimGray;
                else dayPanels[i].BackColor = Color.FromArgb(45, 45, 48);
            }
        }

        private void UpdateMilestoneProgress()
        {
            if (_user == null) return;
            int current = _user.LongestStreak;
            int monthlyGoal = 30;

            pbMilestone.Minimum = 0;
            pbMilestone.Maximum = monthlyGoal;
            pbMilestone.Value = Math.Min(current, monthlyGoal);
            lblLongestStreak.Text = $"Record: {current} / {monthlyGoal} days to Mastery";
            pbMilestone.Refresh();
        }

        // Navigation
        private void SwitchPage(Form newPage) { _isNavigating = true; newPage.Show(); this.Hide(); }
        private void btnNavHome_Click(object sender, EventArgs e) { }
        private void btnNavGoal_Click(object sender, EventArgs e) => SwitchPage(new Goal(this, _user));
        private void btnNavTrans_Click(object sender, EventArgs e) => SwitchPage(new TransactionForm(this, _user));
        private void btnNavSum_Click(object sender, EventArgs e) => SwitchPage(new SummaryForm(this, _user));
        private void btnNavPred_Click(object sender, EventArgs e) => SwitchPage(new PredictionForm(this, _user));
        private void btnNavLogout_Click(object sender, EventArgs e) { new LoginForms().Show(); this.Dispose(); }
    }
}