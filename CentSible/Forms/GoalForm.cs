using CentSible.Database;
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


namespace CentSible.Forms
{
    public partial class GoalForm : Form
    {
        private Form _home;
        private Account _user;
        private bool _isNavigating = false;
        private List<Models.Goal> _allGoals;
        private GoalLogic _goalLogic = new GoalLogic();
        private GoalCategory _activeType = GoalCategory.Spending;

        public GoalForm(Form home, Account user)
        {
            InitializeComponent();
            _home = home;
            _user = user;
        }

        private void GoalForm_Load(object sender, EventArgs e)
        {
            if (_user == null) return;

            
            SelectMonthDropGoal.SelectedIndexChanged -= cbSelectMonth_SelectedIndexChanged;
            SelectYearDropGoal.ValueChanged -= numSelectYear_ValueChanged;

            SelectMonthDropGoal.SelectedIndex = DateTime.Now.Month - 1;
            SelectYearDropGoal.Value = DateTime.Now.Year;

            SelectMonthDropGoal.SelectedIndexChanged += cbSelectMonth_SelectedIndexChanged;
            SelectYearDropGoal.ValueChanged += numSelectYear_ValueChanged;

            UpdateGoalDate();
            UpdateFilter();
        }

       
        private void UpdateGoalDate()
        {
            string month = SelectMonthDropGoal.SelectedIndex >= 0
                ? SelectMonthDropGoal.Items[SelectMonthDropGoal.SelectedIndex].ToString()
                : DateTime.Now.ToString("MMMM");
            int year = (int)SelectYearDropGoal.Value;
            GoalDateLabelGoal.Text = $"{month} {year}";
        }

        
        private void UpdateDaysRemaining()
        {
            int days = (TargetDateDropDownGoal.Value.Date - DateTime.Today).Days;
            DaysRemainingLabelGoal.Text = days >= 0 ? $"{days} Days" : "Overdue";
        }

        private void UpdateFilter()
        {
            if (_user == null) return;
            _allGoals = _goalLogic.GetGoals(
                _user.AccountID,
                SelectMonthDropGoal.SelectedIndex + 1,
                (int)SelectYearDropGoal.Value);
            SetMode(_activeType);
        }
        private void SetMode(GoalCategory type)
        {
            _activeType = type;
            string modeText = (type == GoalCategory.Spending) ? "Spending" : "Saving";

            dynamicGoalLabel.Text = $"{modeText} Goal";
            dynamicIndicatorLabel.Text = $"{modeText} Indicator";

            var goal = _allGoals?.Find(g => g.GoalType == type);

            if (goal != null)
            {
                TargetAmountTextGoal.Text = goal.TargetAmount.ToString();
                CurrentAmountTextGoal.Text = goal.CurrentAmount.ToString();
                TargetDateDropDownGoal.Value = goal.TargetDate;

                lblIndicatorSpent.Text = $"₱ {goal.CurrentAmount:N0}";
                lblIndicatorTarget.Text = $"₱ {goal.TargetAmount:N0}";

                UpdateIndicators(goal);  
                IndicatorFlowLayGoal.Visible = true;
            }
            else
            {
              
                
                TargetAmountTextGoal.Text = "";
                CurrentAmountTextGoal.Text = "";
                lblIndicatorSpent.Text = "₱ 0";
                lblIndicatorTarget.Text = "₱ 0";
                pbGoalProgress.Value = 0;           
                IndicatorPercentLabelGoal.Text = "0%";
                MilestoneBarGoal.Value = 0;         
                MilestoneDescLabelGoal.Text = "No goal set for this period.";
                DaysToGoLabelGoal.Text = "0 Days";
                IndicatorDaysLabelGoal.Text = "0 Days";

            }
        }

        private void UpdateIndicators(Models.Goal goal)
        {
            var metrics = _goalLogic.GetCalculatedMetrics(goal);

            pbGoalProgress.Value = metrics.TotalPercent;
            IndicatorPercentLabelGoal.Text = $"{metrics.TotalPercent}%";
            MilestoneBarGoal.Value = metrics.MilestoneStep;
            MilestoneDescLabelGoal.Text = metrics.StatusNote;
            DaysToGoLabelGoal.Text = metrics.DaysText;
            IndicatorDaysLabelGoal.Text = metrics.DaysText;
        }
        private void btnUpdateGoal_Click(object sender, EventArgs e)
        {
            
            bool isTargetValid = double.TryParse(TargetAmountTextGoal.Text, out double target);
            bool isCurrentValid = double.TryParse(CurrentAmountTextGoal.Text, out double current);

            if (!isTargetValid || !isCurrentValid)
            {
                MessageBox.Show("Please enter valid numbers for the amounts.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Models.Goal data = new Models.Goal
            {
                AccountID = _user.AccountID,
                GoalType = _activeType,
                TargetAmount = target,
                CurrentAmount = current,
                TargetDate = TargetDateDropDownGoal.Value
            };

            if (_goalLogic.SaveOrUpdateGoal(data))
            {
                UpdateFilter(); 
                MessageBox.Show("Goal saved!");
            }
        }

        private void btnSpendingTab_Click(object sender, EventArgs e) => SetMode(GoalCategory.Spending);
        private void btnSavingTab_Click(object sender, EventArgs e) => SetMode(GoalCategory.Savings);

        
        private void cbSelectMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateGoalDate();
            UpdateFilter();
            SyncDatePickerToSelectedPeriod();
        }

        private void numSelectYear_ValueChanged(object sender, EventArgs e)
        {
            UpdateGoalDate();
            UpdateFilter();
            SyncDatePickerToSelectedPeriod();
        }

        private void SyncDatePickerToSelectedPeriod()
        {
            int month = SelectMonthDropGoal.SelectedIndex + 1;
            int year = (int)SelectYearDropGoal.Value;
            int lastDay = DateTime.DaysInMonth(year, month);

            TargetDateDropDownGoal.MinDate = new DateTime(2000, 1, 1);
            TargetDateDropDownGoal.MaxDate = new DateTime(3000, 12, 31);

            TargetDateDropDownGoal.Value = new DateTime(year, month, lastDay);

            UpdateFilter();
            UpdateDaysRemaining();
        }

        private void TargetDateDropDownGoal_ValueChanged(object sender, EventArgs e) => UpdateDaysRemaining();
        private void SwitchPage(Form newPage) { _isNavigating = true; newPage.Show(); this.Hide(); }
        private void HomeButtonGoal_Click(object sender, EventArgs e) {
            _isNavigating = true;
            _home.Show();
            this.Close();
        }
        private void GoalButtonGoal_Click(object sender, EventArgs e) { }
        private void TranButtonGoal_Click(object sender, EventArgs e) => SwitchPage(new TransactionForm(_home, _user));
        private void SumButtonGoal_Click(object sender, EventArgs e) => SwitchPage(new SummaryForm(_home, _user));
        private void PredButtonGoal_Click(object sender, EventArgs e) => SwitchPage(new PredictionForm(_home, _user));
        private void LogoutButtonGoal_Click(object sender, EventArgs e) { _isNavigating = true; new LoginForms().Show(); this.Dispose(); }

        private void GoalForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_isNavigating && e.CloseReason == CloseReason.UserClosing) Application.Exit();
        }
    }
}