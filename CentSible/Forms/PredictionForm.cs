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

        public PredictionForm(Form home, Account user)
        {
            InitializeComponent();
            _home = home;
            _user = user;

            this.VisibleChanged += PredictionForm_VisibleChanged;
            this.cbSelectMonthPred.SelectedIndexChanged += cbSelectMonthPred_SelectedIndexChanged;
        }

        private void PredictionForm_Load(object sender, EventArgs e)
        {
            if (_user == null) return;

            numSelectYearPred.Minimum = 2000;
            numSelectYearPred.Maximum = 3000;
            numSelectYearPred.Value = DateTime.Now.Year;
            numSelectYearPred.Enabled = false;    
            cbSelectMonthPred.SelectedIndex = DateTime.Now.Month - 1;      
            PredButtonGoal.BackColor = Color.FromArgb(212, 236, 204);
            PredButtonGoal.ForeColor = Color.Black;
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

        private void GoalButtonGoal_Click(object sender, EventArgs e) => SwitchPage(new GoalForm(_home, _user));
        private void TranButtonGoal_Click(object sender, EventArgs e) => SwitchPage(new TransactionForm(_home, _user));     
        private void SumButtonGoal_Click(object sender, EventArgs e) => SwitchPage(new SummaryForm(_home, _user));
        private void PredButtonGoal_Click(object sender, EventArgs e) { }
        private void LogoutButtonGoal_Click(object sender, EventArgs e)
        {
            _isNavigating = true;
            new LoginForms().Show();
            this.Dispose();
           
        }

        private void PredictionForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_isNavigating && e.CloseReason == CloseReason.UserClosing)
                Application.Exit();
            
        }
    }
}