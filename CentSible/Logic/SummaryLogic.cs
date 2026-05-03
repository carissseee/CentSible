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

        public string GetHighestCategory(Dictionary<string, decimal> spending)
        {
            string highestCategory = "";
            decimal highestAmount = 0;
            foreach (KeyValuePair<string, decimal> item in spending)
            {
                if (item.Value > highestAmount)
                {
                    highestAmount = item.Value;
                    highestCategory = item.Key;
                }
            }
            return highestCategory;
        }

        public string GetLowestCategory(Dictionary<string, decimal> spending)
        {
            string lowestCategory = "";
            decimal lowestAmount = decimal.MaxValue;
            foreach (KeyValuePair<string, decimal> item in spending)
            {
                if (item.Value < lowestAmount)
                {
                    lowestAmount = item.Value;
                    lowestCategory = item.Key;
                }
            }
            return lowestCategory;
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
