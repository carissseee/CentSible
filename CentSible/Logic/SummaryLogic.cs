using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CentSible.Database;
using CentSible.Models;

namespace CentSible.Logic
{
    public class SummaryLogic
    {
        private SummaryDB summaryDB = new SummaryDB();

        public Dictionary<string, decimal> GetSpendingByCategory(int accountID, int month, int year)
        {
            return summaryDB.GetSpendingByCategory(accountID, month, year);
        }

        public decimal GetTotalSpent(Dictionary<string, decimal> spending)
        {
            decimal total = 0;
            foreach (KeyValuePair<string, decimal> item in spending)
            {
                total += item.Value;
            }
            return total;
        }

        public List<string> GetAllHighestCategories(Dictionary<string, decimal> spending)
        {
            List<string> highestCategories = new List<string>();
            decimal highestAmount = 0;
            foreach (KeyValuePair<string, decimal> item in spending)
            {
                if (item.Value > highestAmount)
                {
                    highestAmount = item.Value;
                }
            }

            foreach (KeyValuePair<string, decimal> item in spending)
            {
                if (item.Value == highestAmount)
                {
                    highestCategories.Add(item.Key);
                }
            }
            return highestCategories;
        }

        public List<string> GetAllLowestCategories(Dictionary<string, decimal> spending)
        {
            List<string> lowestCategories = new List<string>();
            decimal lowestAmount = decimal.MaxValue;
            foreach (KeyValuePair<string, decimal> item in spending)
            {
                if (item.Value < lowestAmount)
                {
                    lowestAmount = item.Value;
                }
            }

            foreach (KeyValuePair<string, decimal> item in spending)
            {
                if (item.Value == lowestAmount)
                {
                    lowestCategories.Add(item.Key);
                }
            }
            return lowestCategories;
        }

        public decimal GetPercentage(decimal categoryAmount, decimal totalAmount)
        {
            if (totalAmount == 0)
            {
                return 0;
            }
            return Math.Round((categoryAmount/totalAmount) * 100, 0);
        }
    }
}
