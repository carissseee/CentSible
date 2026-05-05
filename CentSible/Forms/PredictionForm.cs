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
    public partial class PredictionForm : Form
    {
        private Form _home;
        private Account _user;
        private bool _isNavigating = false;
        private PredictionLogic _predLogic = new PredictionLogic();

        public PredictionForm(Account user)
        {
            InitializeComponent();
            _user = user;

            this.VisibleChanged += PredictionForm_VisibleChanged;
            this.cbSelectMonthPred.SelectedIndexChanged += cbSelectMonthPred_SelectedIndexChanged;

            var homeGroup = new Control[] { HomeButtonPred, HomeTabLayPred };
            UIHelper.WireHoverRecursive(HomeButtonPred, homeGroup);
            UIHelper.WireHoverRecursive(HomeTabLayPred, homeGroup);

            var goalGroup = new Control[] { GoalButtonPred, GoalTabLayPred };
            UIHelper.WireHoverRecursive(GoalButtonPred, goalGroup);
            UIHelper.WireHoverRecursive(GoalTabLayPred, goalGroup);

            var tranGroup = new Control[] { TranButtonPred, TranTabLayPred };
            UIHelper.WireHoverRecursive(TranButtonPred, tranGroup);
            UIHelper.WireHoverRecursive(TranTabLayPred, tranGroup);

            var sumGroup = new Control[] { SumButtonPred, SumTabLayPred };
            UIHelper.WireHoverRecursive(SumButtonPred, sumGroup);
            UIHelper.WireHoverRecursive(SumTabLayPred, sumGroup);
            
            UIHelper.WireClickRecursive(HomeTabLayPred, HomeButtonPred_Click);
            UIHelper.WireClickRecursive(GoalTabLayPred, GoalButtonPred_Click);
            UIHelper.WireClickRecursive(SumTabLayPred, SumButtonPred_Click);
            UIHelper.WireClickRecursive(PredTabLayPred, TranButtonPred_Click);
        }

        private void PredictionForm_Load(object sender, EventArgs e)
        {
            if (_user == null) return;

            numSelectYearPred.Minimum = 2000;
            numSelectYearPred.Maximum = 3000;
            numSelectYearPred.Value = DateTime.Now.Year;
            numSelectYearPred.Enabled = false;    
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

               
                lblPredSpendingAmount.Text = $"₱ {result.AvgSpent:N0}";
                lblPredSavingAmount.Text = $"₱ {result.PredictedSaving:N0}";
                lblContextDate.Text = $"{cbSelectMonthPred.SelectedItem} {year}";

                
                chartForecast.Series["Expense"].Points.Clear();
                chartForecast.Series["Budget"].Points.Clear();
                chartForecast.Series["Saving"].Points.Clear();

                foreach (var data in result.History)
                {
                   
                    chartForecast.Series["Expense"].Points.AddXY(data.MonthName, data.Spent);

                   
                    chartForecast.Series["Budget"].Points.AddXY(data.MonthName, data.Budget);

                  
                    chartForecast.Series["Saving"].Points.AddXY(data.MonthName, data.Budget - data.Spent);
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

       
        private void SwitchPage(Form newPage)
        {
            _isNavigating = true;
            
            newPage.Show();
            this.Hide();
        }

        private void HomeButtonGoal_Click(object sender, EventArgs e)
        {
            _isNavigating = true;
            _home.Show();        
            this.Close();
        }

        private void HomeButtonPred_Click(object sender, EventArgs e) => Navigator.SwitchTo(this, Navigator.Home);

        private void GoalButtonPred_Click(object sender, EventArgs e) => Navigator.SwitchTo(this, Navigator.Goal);
        private void TranButtonPred_Click(object sender, EventArgs e) => Navigator.SwitchTo(this, Navigator.Transaction);
        private void SumButtonPred_Click(object sender, EventArgs e) => Navigator.SwitchTo(this, Navigator.Summary);
        private void LogoutButtonPred_Click(object sender, EventArgs e) => Navigator.Logout(this);

        private void PredictionForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing && Navigator.Home != null)
                Application.Exit();
        }


    }
}