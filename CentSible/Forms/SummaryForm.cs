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

        public SummaryForm(Account user)
        {
            InitializeComponent();
            _user = user;

            var homeGroup = new Control[] { HomeButtonSum, HomeTabLaySum };
            UIHelper.WireHoverRecursive(HomeButtonSum, homeGroup);
            UIHelper.WireHoverRecursive(HomeTabLaySum, homeGroup);

            var goalGroup = new Control[] { GoalButtonSum, GoalTabLaySum };
            UIHelper.WireHoverRecursive(GoalButtonSum, goalGroup);
            UIHelper.WireHoverRecursive(GoalTabLaySum, goalGroup);

            var tranGroup = new Control[] { TranButtonSum, TranTabLaySum };
            UIHelper.WireHoverRecursive(TranButtonSum, tranGroup);
            UIHelper.WireHoverRecursive(TranTabLaySum, tranGroup);

            var predGroup = new Control[] { PredButtonSum, PredTabLaySum };
            UIHelper.WireHoverRecursive(PredButtonSum, predGroup);
            UIHelper.WireHoverRecursive(PredTabLaySum, predGroup);

            UIHelper.WireClickRecursive(HomeTabLaySum, HomeButtonSum_Click);
            UIHelper.WireClickRecursive(GoalTabLaySum, GoalButtonSum_Click);
            UIHelper.WireClickRecursive(SumTabLaySum, TranButtonSum_Click);
            UIHelper.WireClickRecursive(PredTabLaySum, PredButtonSum_Click);
        }

        private void SummaryForm_Load(object sender, EventArgs e)
        {
            if (_user == null)
            {
                return;
            }

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

            List<string> onlyCategories = summaryLogic.GetAllHighestCategories(spending);
            string onlyCategory = onlyCategories[0];
            decimal onlyPercent = summaryLogic.GetPercentage(GetCategoryAmount(spending, onlyCategory), totalSpent);
            if (spending.Count == 1)
            {
                lblMSummary.Text = "In " + monthName + ", total expenditures reached ₱" + totalSpent.ToString("N0") + ". " +
                                   "All spending went to " + onlyCategory + " (" + onlyPercent + "%).";
                return;
            }

            List<string> highestCategories = summaryLogic.GetAllHighestCategories(spending);
            List<string> lowestCategories = summaryLogic.GetAllLowestCategories(spending);
            decimal tiedPercent = summaryLogic.GetPercentage(GetCategoryAmount(spending, highestCategories[0]), totalSpent);
            decimal highestPercent = summaryLogic.GetPercentage(GetCategoryAmount(spending, highestCategories[0]), totalSpent);
            decimal lowestPercent = summaryLogic.GetPercentage(GetCategoryAmount(spending, lowestCategories[0]), totalSpent);
            if (spending.Count == 2)
            {
                if (highestCategories.Count == 2)
                {
                   lblMSummary.Text = "In " + monthName + ", total expenditures reached ₱" + totalSpent.ToString("N0") + ". " +
                                       "Spending was equally split between " + highestCategories[0] + " and " + highestCategories[1] +
                                       " (both at " + tiedPercent + "%).";
                }
                else
                {
                    lblMSummary.Text = "In " + monthName + ", total expenditures reached ₱" + totalSpent.ToString("N0") + ". " +
                                       "The largest shre went to " + highestCategories[0] + " (" + highestPercent + "%), " +
                                       "while the smallest portion was " + lowestCategories[0] + lowestCategories[0] + " (" + lowestPercent + "&).";
                }
                return;
            }
            if (spending.Count >= 3)
            {
                if (highestCategories.Count == spending.Count)
                {
                    lblMSummary.Text = "In " + monthName + ", total expenditures reached ₱" + totalSpent.ToString("N0") + ". " +
                                       "Spending was equally distributed accross all " + spending.Count + " categories at " + highestPercent + "% each.";
                    return;
                }

                string highestText = "";
                if (highestCategories.Count == 1)
                {
                    highestText = highestCategories[0] + " (" + highestPercent + "%)";
                }
                else if (highestCategories.Count == 2)
                {
                    highestText = highestCategories[0] + " and " + highestCategories[1] + " (both tied at " + highestPercent + "%)";
                }
                else
                {
                    string allText = string.Join(", ", highestCategories.GetRange(0, highestCategories.Count - 1));
                    highestText = allText + " and " + highestCategories[highestCategories.Count - 1] + " (all tied at " + highestPercent + "%)";
                }

                string lowestText = "";
                if (lowestCategories.Count == 1)
                {
                    lowestText = lowestCategories[0] + " (" + lowestPercent + "%)";
                }
                else if (lowestCategories.Count == 2)
                {
                    lowestText = lowestCategories[0] + " and " + lowestCategories[1] + " (both tied at " + lowestPercent + "%)";
                }
                else
                {
                    string allText = string.Join(", ", lowestCategories.GetRange(0, lowestCategories.Count - 1));
                    lowestText = allText + " and " + lowestCategories[lowestCategories.Count - 1] + " (all tied at " + lowestPercent + "%)";
                }

                lblMSummary.Text = "In " + monthName + ", total expenditures reached ₱" + totalSpent.ToString("N0") + ". " +
                                   "The largest share went to " + highestText + ", " + "while the smallest portion went to " + lowestText + ". " +
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

        private void HomeButtonSum_Click(object sender, EventArgs e) => Navigator.SwitchTo(this, Navigator.Home);
        private void GoalButtonSum_Click(object sender, EventArgs e) => Navigator.SwitchTo(this, Navigator.Goal);
        private void TranButtonSum_Click(object sender, EventArgs e) => Navigator.SwitchTo(this, Navigator.Transaction);
        private void PredButtonSum_Click(object sender, EventArgs e) => Navigator.SwitchTo(this, Navigator.Prediction);
        private void LogoutButtonSum_Click(object sender, EventArgs e) => Navigator.Logout(this);

        private void SummaryForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing && Navigator.Home == null) return;
            if (e.CloseReason == CloseReason.UserClosing) Application.Exit();
        }
    }
}