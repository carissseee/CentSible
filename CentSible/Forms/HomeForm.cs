using CentSible.Database;
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
    public partial class HomeForm : Form
    {
        private Account _user;
        private bool _isNavigating = false;
        private GoalLogic _goalLogic;
        private AccountLogic _accountLogic = new AccountLogic();

        private TransactionLogic _tLogic = new TransactionLogic();
        private TransactionDB _db = new TransactionDB();

        public HomeForm(Account user)
        {
            InitializeComponent();
            _user = user;
            _goalLogic = new GoalLogic();

            var goalGroup = new Control[] { GoalBtnHome, GoalTabLayHome };
            UIHelper.WireHoverRecursive(GoalBtnHome, goalGroup);
            UIHelper.WireHoverRecursive(GoalTabLayHome, goalGroup);

            var sumGroup = new Control[] { SumBtnHome, SumTabLayHome };
            UIHelper.WireHoverRecursive(SumBtnHome, sumGroup);
            UIHelper.WireHoverRecursive(SumTabLayHome, sumGroup);

            var tranGroup = new Control[] { TranBtnHome, TranTabLayHome };
            UIHelper.WireHoverRecursive(TranBtnHome, tranGroup);
            UIHelper.WireHoverRecursive(TranTabLayHome, tranGroup);

            var predGroup = new Control[] { PredBtnHome, PredTabLayHome };
            UIHelper.WireHoverRecursive(PredBtnHome, predGroup);
            UIHelper.WireHoverRecursive(PredTabLayHome, predGroup);

            var logGroup = new Control[] { LogoutBtnHome, LogTabLayHome };
            UIHelper.WireHoverRecursive(LogoutBtnHome, logGroup);
            UIHelper.WireHoverRecursive(LogTabLayHome, logGroup);

            UIHelper.WireClickRecursive(GoalTabLayHome, GoalButtonHome_Click);
            UIHelper.WireClickRecursive(SumTabLayHome, SumButtonHome_Click);
            UIHelper.WireClickRecursive(TranTabLayHome, TranButtonHome_Click);
            UIHelper.WireClickRecursive(PredTabLayHome, PredButtonHome_Click);
            UIHelper.WireClickRecursive(LogTabLayHome, LogoutButtonHome_Click);
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            if (_user == null) return;
            RefreshAllData();
        }

        private void HomeForm_Activated(object sender, EventArgs e)
        {
            if (_user == null) return;
            RefreshAllData();
            this.ActiveControl = null;
            this.Refresh();
        }

        private void RefreshAllData()
        {
            UpdateStreakDisplay();
            UpdateTotalSpent();
            UpdateHomeDashboard();
            UpdateWeeklyActivity();
            UpdateMilestoneProgress();
            UpdateRecentTransactionsTable();
            UpdateHeaderLabels();
        }

        private void UpdateHeaderLabels()
        {
            if (_user == null) return;

            string monthYear = DateTime.Now.ToString("MMMM yyyy");
            GoodMorningLblHome.Text = $"Good day, {_user.Username}!";
            FinancialOverviewLblHome.Text = $"Here’s your financial overview for {monthYear}";
        }

        private void UpdateRecentTransactionsTable()
        {
            try
            {
                RecentTranDGVHome.DataSource = null;
                var recent = _db.GetRecentTransactions(_user.AccountID, 5);
                RecentTranDGVHome.DataSource = recent.Select(t =>
                {
                    decimal truncAmount = Math.Truncate(t.Amount * 100) / 100;

                    return new
                    {
                        Date = t.Date.ToString("MMM dd"),
                        Description = t.Description,
                        Category = t.Category.ToString(),
                        Amount = (t.TransactionType == TransactionType.Expense ? "- ₱ " : "+ ₱ ") + truncAmount.ToString("F2")
                    };
                }).ToList();

                RecentTranDGVHome.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                RecentTranDGVHome.AllowUserToAddRows = false;
                RecentTranDGVHome.RowHeadersVisible = false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Table Update Error: " + ex.Message);
            }
        }

        private void UpdateStreakDisplay()
        {
            CurrentStreakLblHome.Text = _user.LoginStreak.ToString();
            DaysLblHome.Text = _user.LoginStreak == 1 ? "Day" : "Days";
        }

        private void UpdateTotalSpent()
        {
            try
            {
                DateTime now = DateTime.Now;
                var monthlyTransactions = _db.GetTransactions(_user.AccountID, now.Month, now.Year);
                decimal totalSpent = _tLogic.GetTotalSpent(monthlyTransactions);
                decimal totalBudget = monthlyTransactions
                    .Where(t => t.TransactionType == TransactionType.Budget)
                    .Sum(t => t.Amount);
                decimal truncSpent = Math.Truncate(totalSpent * 100) / 100;
                decimal truncBudget = Math.Truncate(totalBudget * 100) / 100;

                if (totalBudget > 0)
                {
                    MoneySpentLabelHome.Text = $"₱ {truncSpent:F2} / ₱ {truncBudget:F2}";
                    double rawPercent = (double)(totalSpent / totalBudget) * 100;
                    int percent = (int)Math.Min(Math.Max(rawPercent, 0), 100);
                    SpentBarHome.Value = percent;
                }
                else
                {
                    MoneySpentLabelHome.Text = $"₱ {truncSpent:F2} / ₱ 0.00";
                    SpentBarHome.Value = 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        private void UpdateMilestoneProgress()
        {
            if (_user == null) return;

            var metrics = _accountLogic.GetStreakMetrics(_user);

            MilestoneBarHome.Minimum = 0;
            MilestoneBarHome.Maximum = metrics.MaxGoal;
            MilestoneBarHome.Value = Math.Min(metrics.LongestStreak, metrics.MaxGoal);
            LongestStreakLblHome.Text = metrics.StreakText;
            LongestStreakLblHome.ForeColor = metrics.StatusColor;
            MilestoneBarHome.ForeColor = metrics.StatusColor;
            MilestoneBarHome.Refresh();
        }

        private void UpdateHomeDashboard()
        {
            var goals = _goalLogic.GetGoals(_user.AccountID, DateTime.Now.Month, DateTime.Now.Year);
            string month = DateTime.Now.ToString("MMMM");


            SpendBarHome.Value = 0;
            SavingBarHome.Value = 0;
            SpendStatLabelHome.Text = $"No spending goal set for {month}";
            SaveStatLabelHome.Text = $"No savings goal set for {month}";

            foreach (var goal in goals)
            {
                if (goal.TargetAmount <= 0) continue;

               
                double raw = (double)(goal.CurrentAmount / goal.TargetAmount) * 100;
                int percent = (int)Math.Min(Math.Max(raw, 0), 100);
                decimal truncCurrent = Math.Truncate(goal.CurrentAmount * 100) / 100;
                decimal truncTarget = Math.Truncate(goal.TargetAmount * 100) / 100;
                string display = $"₱ {truncCurrent:N2} / ₱ {truncTarget:N2}";

                if (goal.GoalType == GoalCategory.Spending)
                {
                    SpendBarHome.Value = percent;
                    SpendStatLabelHome.Text = display;
                }
                else if (goal.GoalType == GoalCategory.Savings)
                {
                    SavingBarHome.Value = percent;
                    SaveStatLabelHome.Text = display;
                }
            }
        }

        private void UpdateWeeklyActivity()
        {
            Panel[] dayPanels = { MonPanelHome, TuePanelHome, WedPanelHome, ThuPanelHome, FriPanelHome, SatPanelHome, SunPanelHome };
            DateTime today = DateTime.Today;
            int diff = (7 + (today.DayOfWeek - DayOfWeek.Monday)) % 7;
            DateTime startOfWeek = today.AddDays(-diff).Date;

            for (int i = 0; i < 7; i++)
            {
                DateTime target = startOfWeek.AddDays(i).Date;
                if (target == today) dayPanels[i].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(46)))), ((int)(((byte)(27)))));
                else if (target < today) dayPanels[i].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(110)))), ((int)(((byte)(60)))));
                else dayPanels[i].BackColor = System.Drawing.Color.White;
            }
        }

        private void GoalButtonHome_Click(object sender, EventArgs e) => Navigator.SwitchTo(this, Navigator.Goal);
        private void TranButtonHome_Click(object sender, EventArgs e) => Navigator.SwitchTo(this, Navigator.Transaction);
        private void SumButtonHome_Click(object sender, EventArgs e) => Navigator.SwitchTo(this, Navigator.Summary);
        private void PredButtonHome_Click(object sender, EventArgs e) => Navigator.SwitchTo(this, Navigator.Prediction);

        private void LogoutButtonHome_Click(object sender, EventArgs e) => Navigator.Logout(this);


        private void HomeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_isNavigating && e.CloseReason == CloseReason.UserClosing) Application.Exit();
        }

    }
}