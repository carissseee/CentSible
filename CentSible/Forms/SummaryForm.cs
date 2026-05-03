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
using CentSible.Logic;
using System.Windows.Forms.DataVisualization.Charting;

namespace CentSible.Forms
{
    public partial class SummaryForm : Form
    {
        private Form _home;
        private Account _user;
        private bool _isNavigating = false;
        private SummaryLogic summaryLogic = new SummaryLogic();

        public SummaryForm(Form home, Account user)
        {
            InitializeComponent();
            _home = home;
            _user = user;
        }

        private void SummaryForm_Load(object sender, EventArgs e)
        {
            if (_user == null)
            {
                return;
            }

            SumButtonGoal.BackColor = Color.FromArgb(212, 236, 204);
            SumButtonGoal.ForeColor = Color.Black;

            cmbYear.SelectedIndexChanged -= cmbYear_SelectedIndexChanged;
            int currentYear = DateTime.Now.Year;
            cmbYear.Items.Add(DateTime.Now.Year.ToString());
            cmbYear.SelectedIndex = 0;
            cmbYear.SelectedIndexChanged += cmbYear_SelectedIndexChanged;

            cmbMonth.SelectedIndexChanged -= cmbMonth_SelectedIndexChanged;
            int currentMonth = DateTime.Now.Month;
            for (int i = 1; i <= currentMonth; i++)
            {
                cmbMonth.Items.Add(new DateTime(2026, i, 1).ToString("MMMM"));
            }
            cmbMonth.SelectedIndex = currentMonth - 1;
            cmbMonth.SelectedIndexChanged += cmbMonth_SelectedIndexChanged;

            chartSummary.Series.Clear();
            chartSummary.Series.Add("Spending");
            chartSummary.Series["Spending"].ChartType = SeriesChartType.Pie;
            chartSummary.Legends.Clear();

            LoadSummary();
        }

        private decimal GetCategoryAmount(Dictionary<string, decimal> spending, string category)
        {
            if (spending.ContainsKey(category))
            {
                return spending[category];
            }
            return 0;
        }

        private void LoadSummary()
        {
            if (cmbMonth.SelectedIndex < 0 || cmbYear.SelectedItem == null)
            {
                return;
            }

            int month = cmbMonth.SelectedIndex + 1;
            int year = int.Parse(cmbYear.SelectedItem.ToString());
            lblDate.Text = new DateTime(year, month, 1).ToString("MMMM yyyy");

            Dictionary<string, decimal> spending = summaryLogic.GetSpendingByCategory(_user.AccountID, month, year);

            decimal totalSpent = summaryLogic.GetTotalSpent(spending);
            lblFTotal.Text = "₱ " + GetCategoryAmount(spending, "Food").ToString("N2");
            lblTTotal.Text = "₱ " + GetCategoryAmount(spending, "Transportation").ToString("N2");
            lblUTotal.Text = "₱ " + GetCategoryAmount(spending, "Utilities").ToString("N2");
            lblHTotal.Text = "₱ " + GetCategoryAmount(spending, "Health").ToString("N2");
            lblLTotal.Text = "₱ " + GetCategoryAmount(spending, "Leisure").ToString("N2");
            lblOTotal.Text = "₱ " + GetCategoryAmount(spending, "Others").ToString("N2");

            chartSummary.Series["Spending"].Points.Clear();
            foreach (KeyValuePair<string, decimal> item in spending)
            {
                if (item.Value > 0)
                {
                    chartSummary.Series["Spending"].Points.AddXY(item.Key, item.Value);
                }
            }
            UpdateSummaryReport(spending, totalSpent, month, year);
        }

        private void UpdateSummaryReport(Dictionary<string, decimal> spending, decimal totalSpent, int month, int year)
        {
            string monthName = new DateTime(year, month, 1).ToString("MMMM");
            if (totalSpent == 0)
            {
                lblMSummary.Text = "In " + monthName + ", there are no recorded expenses yet.";
                return;
            }
            else if (spending.Count == 1)
            {
                string onlyCategory = summaryLogic.GetHighestCategory(spending);
                decimal onlyPercent = summaryLogic.GetPercentage(GetCategoryAmount(spending, onlyCategory), totalSpent);

                lblMSummary.Text = "In " + monthName + ", total expedintures reached ₱" + totalSpent.ToString("N0") + ". " +
                                   "All spending went to " + onlyCategory + " (" + onlyPercent + "%).";
            }
            else
            {
                string highestCategory = summaryLogic.GetHighestCategory(spending);
                string lowestCategory = summaryLogic.GetLowestCategory(spending);
                decimal highestPercent = summaryLogic.GetPercentage(GetCategoryAmount(spending, highestCategory), totalSpent);
                decimal lowestPercent = summaryLogic.GetPercentage(GetCategoryAmount(spending, lowestCategory), totalSpent);

                lblMSummary.Text = "In " + monthName + ", total expedintures reached ₱" + totalSpent.ToString("N0") + ". " +
                                "The largest share went to " + highestCategory + " (" + highestPercent + "%), " +
                                "while  the smallest portion was " + lowestCategory + " (" + lowestPercent + "%). " +
                                "Overall spending was recorded accross " + spending.Count + " categories.";
            }
        }

        private void cmbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadSummary();
        }
        private void cmbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadSummary();
        }

        private void SwitchPage(Form newPage) { _isNavigating = true; newPage.Show(); this.Hide(); }
        private void HomeButtonGoal_Click(object sender, EventArgs e) { _isNavigating = true; _home.Show(); this.Hide(); }
        private void GoalButtonGoal_Click(object sender, EventArgs e) => SwitchPage(new GoalForm(_home, _user));
        private void TranButtonGoal_Click(object sender, EventArgs e) => SwitchPage(new TransactionForm(_home, _user));
        private void SumButtonGoal_Click(object sender, EventArgs e) { }
        private void PredButtonGoal_Click(object sender, EventArgs e) => SwitchPage(new PredictionForm(_home, _user));
        private void LogoutButtonGoal_Click(object sender, EventArgs e) { _isNavigating = true; new LoginForms().Show(); this.Dispose(); }

        private void SummaryForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_isNavigating && e.CloseReason == CloseReason.UserClosing) Application.Exit();
        }
    }
}