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
    public partial class PredictionForm : BaseNavFormDesigner
    {
        private PredictionLogic _predLogic = new PredictionLogic();


        public PredictionForm(Account user) : base(user)
        {
            InitializeComponent();
            this.VisibleChanged += PredictionForm_VisibleChanged;
            this.cbSelectMonthPred.SelectedIndexChanged += cbSelectMonthPred_SelectedIndexChanged;
            InitializeNavigation(); 

        }

        protected override void InitializeNavigation()
        {
            var homeGroup = new Control[] { HomeButtonPred, HomeTabLayPred };
            var goalGroup = new Control[] { GoalButtonPred, GoalTabLayPred };
            var tranGroup = new Control[] { TranButtonPred, TranTabLayPred };
            var sumGroup = new Control[] { SumButtonPred, SumTabLayPred };
            var logGroup = new Control[] { LogoutBtnPred, LogTabLayPred };

            UIHelper.WireHoverRecursive(HomeButtonPred, homeGroup);
            UIHelper.WireHoverRecursive(GoalButtonPred, goalGroup);
            UIHelper.WireHoverRecursive(TranButtonPred, tranGroup);
            UIHelper.WireHoverRecursive(SumButtonPred, sumGroup);
            UIHelper.WireHoverRecursive(LogoutBtnPred, logGroup);

            UIHelper.WireClickRecursive(HomeTabLayPred, (s, e) => PerformNavigation(() => Navigator.SwitchTo(this, Navigator.Home)));
            UIHelper.WireClickRecursive(GoalTabLayPred, (s, e) => PerformNavigation(() => Navigator.SwitchTo(this, Navigator.Goal)));
            UIHelper.WireClickRecursive(SumTabLayPred, (s, e) => PerformNavigation(() => Navigator.SwitchTo(this, Navigator.Summary)));
            UIHelper.WireClickRecursive(TranTabLayPred, (s, e) => PerformNavigation(() => Navigator.SwitchTo(this, Navigator.Transaction)));
            UIHelper.WireClickRecursive(LogTabLayPred, (s, e) => Navigator.Logout(this));
        }

        private void PredictionForm_Load(object sender, EventArgs e)
        {
            if (_user == null) return;

            numSelectYearPred.Minimum = DateTime.Now.Year;
            numSelectYearPred.Maximum = DateTime.Now.Year;
            numSelectYearPred.Value = DateTime.Now.Year;
            cbSelectMonthPred.SelectedIndex = DateTime.Now.Month - 1;      
            RunPrediction();
        }

       
        private void RunPrediction()
        {
            try
            {

                int month = cbSelectMonthPred.SelectedIndex + 1;
                int year = (int)numSelectYearPred.Value;
                var result = _predLogic.GetForecast(_user.AccountID, month, year);

                decimal truncSpent = Math.Truncate(result.AvgSpent * 100) / 100;
                decimal truncSaving = Math.Truncate(result.PredictedSaving * 100) / 100;

                PredSpendLblPred.Text = $"₱ {truncSpent:N2}";
                PredSaveLblPred.Text = $"₱ {truncSaving:N2}";
                lblContextDate.Text = $"{cbSelectMonthPred.SelectedItem} {year}";

                
                ForecastChrtPred.Series["Expense"].Points.Clear();
                ForecastChrtPred.Series["Budget"].Points.Clear();
                ForecastChrtPred.Series["Saving"].Points.Clear();

                foreach (var data in result.History)
                {


                    decimal chartSpent = Math.Truncate(data.Spent * 100) / 100;
                    decimal chartBudget = Math.Truncate(data.Budget * 100) / 100;
                    decimal chartSaving = Math.Truncate((data.Budget - data.Spent) * 100) / 100;

                    ForecastChrtPred.Series["Expense"].Points.AddXY(data.MonthName, data.Spent);         
                    ForecastChrtPred.Series["Budget"].Points.AddXY(data.MonthName, data.Budget);       
                    ForecastChrtPred.Series["Saving"].Points.AddXY(data.MonthName, data.Budget - data.Spent);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Refresh Error: " + ex.Message);
            }
        }

        private void PredictionForm_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible) RunPrediction();
            
        }

        private void cbSelectMonthPred_SelectedIndexChanged(object sender, EventArgs e)
        {
            RunPrediction();
          
        }


        private void HomeButtonSum_Click(object sender, EventArgs e) => Navigator.SwitchTo(this, Navigator.Home);
        private void HomeButtonPred_Click(object sender, EventArgs e) => Navigator.SwitchTo(this, Navigator.Home);
        private void GoalButtonPred_Click(object sender, EventArgs e) => Navigator.SwitchTo(this, Navigator.Goal);
        private void TranButtonPred_Click(object sender, EventArgs e) => Navigator.SwitchTo(this, Navigator.Transaction);
        private void SumButtonPred_Click(object sender, EventArgs e) => Navigator.SwitchTo(this, Navigator.Summary);
        private void LogoutBtnPred_Click(object sender, EventArgs e) => Navigator.Logout(this);
    }
}

