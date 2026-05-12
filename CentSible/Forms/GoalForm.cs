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
using System.Globalization;
using Guna.UI2.WinForms;

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

        public GoalForm(Account user)
        {
            InitializeComponent();
            _user = user;

            this.Activated += (s, e) => { if (_user != null) UpdateFilter(); };


            var homeGroup = new Control[] { HomeButtonGoal, HomeTabLayGoal };
            UIHelper.WireHoverRecursive(HomeButtonGoal, homeGroup);
            UIHelper.WireHoverRecursive(HomeTabLayGoal, homeGroup);

            var sumGroup = new Control[] { SumButtonGoal, SumTabLayGoal };
            UIHelper.WireHoverRecursive(SumButtonGoal, sumGroup);
            UIHelper.WireHoverRecursive(SumTabLayGoal, sumGroup);

            var tranGroup = new Control[] { TranButtonGoal, TranTabLayGoal };
            UIHelper.WireHoverRecursive(TranButtonGoal, tranGroup);
            UIHelper.WireHoverRecursive(TranTabLayGoal, tranGroup);

            var predGroup = new Control[] { PredButtonGoal, PredTabLayGoal };
            UIHelper.WireHoverRecursive(PredButtonGoal, predGroup);
            UIHelper.WireHoverRecursive(PredTabLayGoal, predGroup);

            var logGroup = new Control[] { LogoutButtonGoal, LogTabLayGoal };
            UIHelper.WireHoverRecursive(LogoutButtonGoal, logGroup);
            UIHelper.WireHoverRecursive(LogTabLayGoal, logGroup);

            UIHelper.WireClickRecursive(HomeTabLayGoal, HomeButtonGoal_Click);
            UIHelper.WireClickRecursive(SumTabLayGoal, SumButtonGoal_Click);
            UIHelper.WireClickRecursive(TranTabLayGoal, TranButtonGoal_Click);
            UIHelper.WireClickRecursive(PredTabLayGoal, PredButtonGoal_Click);
            UIHelper.WireClickRecursive(LogTabLayGoal, LogoutButtonGoal_Click);
        }

        private void GoalForm_Load(object sender, EventArgs e)
        {
            if (_user == null) return;

            SetActiveTabButton(SpendingBtnGoal);

            SelectMonthDropGoal.SelectedIndexChanged -= cbSelectMonth_SelectedIndexChanged;
            SelectYearDropGoal.ValueChanged -= numSelectYear_ValueChanged;

            SelectMonthDropGoal.SelectedIndex = DateTime.Now.Month - 1;
            SelectYearDropGoal.Minimum = DateTime.Now.Year;
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
            DaysRemainingLblGoal.Text = days >= 0 ? $"{days} Days" : "Overdue";
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

            SpendLblGoal.Text = $"{modeText} Goal";
            IndicatorLblGoal.Text = $"{modeText} Indicator";

            var goal = _allGoals?.Find(g => g.GoalType == type);

            if (goal != null)
            {
                
                decimal truncCurrent = Math.Truncate((decimal)goal.CurrentAmount * 100) / 100;
                decimal truncTarget = Math.Truncate((decimal)goal.TargetAmount * 100) / 100;
                TargetAmountTxtGoal.Text = truncTarget.ToString("F2");
                CurrentAmountTxtGoal.Text = truncCurrent.ToString("F2");
                TargetDateDropDownGoal.Value = goal.TargetDate;
                IndicatorLblSpent.Text = $"₱ {truncCurrent.ToString("N2")}";
                IndicatorLblTarget.Text = $"₱ {truncTarget.ToString("N2")}";

                UpdateIndicators(goal);
                IndicatorPnlGoal.Visible = true;
            }
            else
            {
                TargetAmountTxtGoal.Text = "";
                CurrentAmountTxtGoal.Text = "";
                IndicatorLblSpent.Text = "₱ 0.00";
                IndicatorLblTarget.Text = "₱ 0.00";
                CurrentBarGoal.Value = 0;
                IndicatorPercentLblGoal.Text = "0%";
                MilestoneBarGoal.Value = 0;
                MilestoneDescLblGoal.Text = "No goal set for this period.";
                DaysToGoLblGoal.Text = "0 Days";
                IndicatorDaysLblGoal.Text = "0 Days";
            }
        }

        private void UpdateIndicators(Models.Goal goal)
        {
            var metrics = _goalLogic.GetCalculatedMetrics(goal);

            CurrentBarGoal.Value = metrics.TotalPercent;
            IndicatorPercentLblGoal.Text = $"{metrics.TotalPercent}%";
            MilestoneBarGoal.Value = metrics.MilestoneStep;
            MilestoneDescLblGoal.Text = metrics.StatusNote;
            DaysToGoLblGoal.Text = metrics.DaysText;
            IndicatorDaysLblGoal.Text = metrics.DaysText;
        }

        private void SaveBtnGoal_Click(object sender, EventArgs e)
        {
            
            bool isTargetValid = decimal.TryParse(TargetAmountTxtGoal.Text,
                                                NumberStyles.AllowDecimalPoint,
                                                CultureInfo.InvariantCulture,
                                                out decimal target);

            bool isCurrentValid = decimal.TryParse(CurrentAmountTxtGoal.Text,
                                                 NumberStyles.AllowDecimalPoint,
                                                 CultureInfo.InvariantCulture,
                                                 out decimal current);

            if (!isTargetValid || !isCurrentValid)
            {
                MessageBox.Show("Please Enter Valid Numbers.",
                                "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (_goalLogic.ProcessGoalEntry(_user.AccountID, _activeType, target, current, TargetDateDropDownGoal.Value))
                {
                    UpdateFilter();
                    MessageBox.Show("Goal saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Guna2Button _activeTabButton = null;

        private void SetActiveTabButton(Guna2Button btn)
        {
            if (_activeTabButton != null)
            {
                _activeTabButton.FillColor = SystemColors.Control;
                _activeTabButton.ForeColor = SystemColors.ControlText;
            }

            btn.FillColor = Color.DarkGreen;
            btn.ForeColor = Color.White;
            _activeTabButton = btn;
        }

        private void SpendingBtnGoal_Click(object sender, EventArgs e)
        {
            SetActiveTabButton(SpendingBtnGoal);
            SetMode(GoalCategory.Spending);
        }

        private void SavingBtnGoal_Click(object sender, EventArgs e)
        {
            SetActiveTabButton(SavingBtnGoal);
            SetMode(GoalCategory.Savings);
        }

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

            TargetDateDropDownGoal.MinDate = new DateTime(DateTime.Now.Year, 1, 1);
            TargetDateDropDownGoal.MaxDate = new DateTime(3000, 12, 31);

            TargetDateDropDownGoal.Value = new DateTime(year, month, lastDay);

            UpdateFilter();
            UpdateDaysRemaining();
        }

        private void TargetDateDropDownGoal_ValueChanged(object sender, EventArgs e) => UpdateDaysRemaining();
        private void HomeButtonGoal_Click(object sender, EventArgs e) => Navigator.SwitchTo(this, Navigator.Home);
        private void TranButtonGoal_Click(object sender, EventArgs e) => Navigator.SwitchTo(this, Navigator.Transaction);
        private void SumButtonGoal_Click(object sender, EventArgs e) => Navigator.SwitchTo(this, Navigator.Summary);
        private void PredButtonGoal_Click(object sender, EventArgs e) => Navigator.SwitchTo(this, Navigator.Prediction);
        private void LogoutButtonGoal_Click(object sender, EventArgs e) => Navigator.Logout(this);

      
        private void GoalForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_isNavigating && e.CloseReason == CloseReason.UserClosing) Application.Exit();
        }
    }
}