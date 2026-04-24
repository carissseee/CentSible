using CentSible.Logic;
using CentSible.Models;
using CentSible.Views;
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


namespace CentSible.Views
{
    public partial class GoalForm : Form
    {
        private Form _home;
        private Account _user;
        private bool _isNavigating = false;
        private List<Goal> _allGoals;
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


            cbSelectMonth.SelectedIndexChanged -= cbSelectMonth_SelectedIndexChanged;
            numSelectYear.ValueChanged -= numSelectYear_ValueChanged;

            cbSelectMonth.SelectedIndex = DateTime.Now.Month - 1;
            numSelectYear.Value = DateTime.Now.Year;

            cbSelectMonth.SelectedIndexChanged += cbSelectMonth_SelectedIndexChanged;
            numSelectYear.ValueChanged += numSelectYear_ValueChanged;

            UpdateGoalDate();
            UpdateFilter();
        }


        private void UpdateGoalDate()
        {
            string month = cbSelectMonth.SelectedIndex >= 0
                ? cbSelectMonth.Items[cbSelectMonth.SelectedIndex].ToString()
                : DateTime.Now.ToString("MMMM");
            int year = (int)numSelectYear.Value;
            lblGoalsHeader.Text = $"{month} {year}";
        }


        private void UpdateDaysRemaining()
        {
            int days = (dtpTargetDate.Value.Date - DateTime.Today).Days;
            lblDaysRemaining.Text = days >= 0 ? $"{days} Days" : "Overdue";
        }

        private void UpdateFilter()
        {
            if (_user == null) return;
            _allGoals = _goalLogic.GetGoals(
                _user.AccountID,
                cbSelectMonth.SelectedIndex + 1,
                (int)numSelectYear.Value);
            SetMode(_activeType);
        }

        private void SetMode(GoalCategory type)
        {
            _activeType = type;


            lblLeftHeader.Text = type == GoalCategory.Spending ? "Spending Goal" : "Saving Goal";


            lblRightHeader.Text = type == GoalCategory.Spending ? "Spending Indicator" : "Saving Indicator";

            var goal = _allGoals?.Find(g => g.GoalType == type);

            if (goal != null)
            {

                txtTargetAmount.Text = goal.TargetAmount.ToString();
                txtCurrentAmount.Text = goal.CurrentAmount.ToString();
                dtpTargetDate.Value = goal.TargetDate;


                lblIndicatorSpent.Text = $"₱ {goal.CurrentAmount:N0}";
                lblIndicatorTarget.Text = $"₱ {goal.TargetAmount:N0}";


                UpdateDaysRemaining();

                UpdateIndicators(goal);
                pnlResults.Visible = true;
            }
            else
            {

                txtTargetAmount.Text = "";
                txtCurrentAmount.Text = "";
                lblIndicatorSpent.Text = "₱ 0";
                lblIndicatorTarget.Text = "₱ 0";
                lblDaysRemaining.Text = "—";
                pnlResults.Visible = false;
            }
        }

        private void UpdateIndicators(Goal goal)
        {
            var metrics = _goalLogic.GetCalculatedMetrics(goal);

            pbGoalProgress.Value = metrics.TotalPercent;
            lblPercentReached.Text = $"{metrics.TotalPercent}%";
            pbMilestone.Value = metrics.MilestoneStep;
            lblMilestoneDesc.Text = metrics.StatusNote;
            lblMilestoneDays.Text = metrics.DaysText;
            lblIndicatorDays.Text = metrics.DaysText;
        }


        private void btnUpdateGoal_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtTargetAmount.Text, out double targetAmount) ||
                !double.TryParse(txtCurrentAmount.Text, out double currentAmount))
            {
                MessageBox.Show("Please enter valid numbers only.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Goal data = new Goal
                {
                    AccountID = _user.AccountID,
                    GoalType = _activeType,
                    TargetAmount = targetAmount,
                    CurrentAmount = currentAmount,
                    TargetDate = dtpTargetDate.Value
                };

                if (_goalLogic.SaveOrUpdateGoal(data))
                {
                    UpdateFilter();
                    MessageBox.Show("Goal saved!");
                }
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }



        private void btnSpendingTab_Click(object sender, EventArgs e) => SetMode(GoalCategory.Spending);
        private void btnSavingTab_Click(object sender, EventArgs e) => SetMode(GoalCategory.Savings);


        private void cbSelectMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateGoalDate();
            SyncDatePickerToSelectedPeriod();
            UpdateFilter();
        }

        private void numSelectYear_ValueChanged(object sender, EventArgs e)
        {
            UpdateGoalDate();
            SyncDatePickerToSelectedPeriod(); //bago
            UpdateFilter();
        }

        private void SyncDatePickerToSelectedPeriod()
        {
            int month = cbSelectMonth.SelectedIndex + 1;


            int year = (int)numSelectYear.Value;

            int lastDay = DateTime.DaysInMonth(year, month);

            dtpTargetDate.MaxDate = new DateTime(year, month, lastDay);

            dtpTargetDate.Value = new DateTime(year, month, lastDay);

            UpdateDaysRemaining();

        }


        private void dtpTargetDate_ValueChanged(object sender, EventArgs e) => UpdateDaysRemaining();
        private void Switch(Form next) { _isNavigating = true; next.Show(); this.Close(); }
        private void btnNavHome_Click(object sender, EventArgs e) { _isNavigating = true; _home.Show(); this.Close(); }
        private void btnNavGoal_Click(object sender, EventArgs e) { }
        private void btnNavTrans_Click(object sender, EventArgs e) => Switch(new TransactionForm(_home, _user));
        private void btnNavSum_Click(object sender, EventArgs e) => Switch(new SummaryForm(_home, _user));
        private void btnNavPred_Click(object sender, EventArgs e) => Switch(new PredictionForm(_home, _user));
        private void btnNavLogout_Click(object sender, EventArgs e) { _isNavigating = true; new LoginForm().Show(); this.Dispose(); }

        private void GoalForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_isNavigating && e.CloseReason == CloseReason.UserClosing) Application.Exit();
        }
    }
}

