using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CentSible.Database;
using CentSible.Models;

namespace CentSible.Logic
{
    public class PredictionLogic
    {
        private TransactionDB _db = new TransactionDB();
        private TransactionLogic _tLogic = new TransactionLogic();

        public PredictionResult GetForecast(int accID, int targetMonth, int targetYear)
        {
            var result = new PredictionResult();
            DateTime target = new DateTime(targetYear, targetMonth, 1);
            decimal sumSpent = 0;
            decimal sumBudget = 0;

            for (int i = 3; i >= 1; i--)
            {
                DateTime pastDate = target.AddMonths(-i);
                var txs = _db.GetTransactions(accID, pastDate.Month, pastDate.Year);

                decimal spent = _tLogic.GetTotalSpent(txs);
                decimal budget = _tLogic.GetTotalBudget(txs);

                result.History.Add(new MonthData
                {
                    MonthName = pastDate.ToString("MMMM"),
                    Spent = spent,
                    Budget = budget
                });

                sumSpent += spent;
                sumBudget += budget;
            }

            result.AvgSpent = sumSpent / 3;
            result.AvgBudget = sumBudget / 3;
            return result;
        }
    }
}