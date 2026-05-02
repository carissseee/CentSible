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
        }

        private void UpdateStreakDisplay()
        {
            
            lblCurrentStreak.Text = _user.LoginStreak.ToString();
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

              
                if (totalBudget > 0)
                {
                    
                    MoneySpentLabelHome.Text = $"₱ {totalSpent:N0} / ₱ {totalBudget:N0}";            
                    double rawPercent = (double)(totalSpent / totalBudget) * 100;
                    int percent = (int)Math.Min(Math.Max(rawPercent, 0), 100);
                    BarSpentHome.Value = percent;
                }
                else
                {
                   
                    MoneySpentLabelHome.Text = $"₱ {totalSpent:N0} / ₱ 0";
                    BarSpentHome.Value = 0;
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

            pbMilestone.Minimum = 0;
            pbMilestone.Maximum = metrics.MaxGoal;
            pbMilestone.Value = Math.Min(metrics.LongestStreak, metrics.MaxGoal);     
            LongestStreakLabelHome.Text = metrics.StreakText;
            LongestStreakLabelHome.ForeColor = metrics.StatusColor;
            pbMilestone.Refresh();
        }

        private void UpdateHomeDashboard()
        {
            var goals = _goalLogic.GetGoals(_user.AccountID, DateTime.Now.Month, DateTime.Now.Year);
            string month = DateTime.Now.ToString("MMMM");

            BarSpendingHome.Value = 0;
            BarSavingHome.Value = 0;
            SpendStatLabelHome.Text = $"No spending goal set for {month}";
            SaveStatLabelHome.Text = $"No savings goal set for {month}";

            foreach (var goal in goals)
            {
                if (goal.TargetAmount <= 0) continue;

                double raw = (goal.CurrentAmount / goal.TargetAmount) * 100;
                int percent = (int)Math.Min(Math.Max(raw, 0), 100);
                string display = $"₱ {goal.CurrentAmount:N0} / ₱ {goal.TargetAmount:N0}";

                if (goal.GoalType == GoalCategory.Spending)
                {
                    BarSpendingHome.Value = percent;
                    SpendStatLabelHome.Text = display;
                }
                else if (goal.GoalType == GoalCategory.Savings)
                {
                    BarSavingHome.Value = percent;
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
                if (target == today) dayPanels[i].BackColor = Color.OrangeRed;
                else if (target < today) dayPanels[i].BackColor = Color.DimGray;
                else dayPanels[i].BackColor = Color.FromArgb(45, 45, 48);
            }
        }

        private void HomeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_isNavigating && e.CloseReason == CloseReason.UserClosing) Application.Exit();
        }

        private void SwitchPage(Form newPage) { _isNavigating = true; newPage.Show(); this.Hide(); }
        private void HomeButtonGoal_Click(object sender, EventArgs e)
        {
            
        }
        private void GoalButtonGoal_Click(object sender, EventArgs e) => SwitchPage(new GoalForm(this, _user));
        private void TranButtonHome_Click(object sender, EventArgs e) => SwitchPage(new TransactionForm(this, _user));
        private void SumButtonGoal_Click(object sender, EventArgs e) => SwitchPage(new SummaryForm(this, _user));
        private void PredButtonGoal_Click(object sender, EventArgs e) => SwitchPage(new PredictionForm(this, _user));
        private void LogoutButtonGoal_Click(object sender, EventArgs e) { _isNavigating = true; new LoginForms().Show(); this.Dispose(); }

       
    }
}
