using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CentSible.Database;
using CentSible.Models;




//namespace CentSible.Logic
//{
//    public class PredictionLogic
//    {
//        private TransactionDB _db = new TransactionDB();
//        private TransactionLogic _tLogic = new TransactionLogic();

//        public class PredictionResult
//        {
//            public decimal AvgSpent { get; set; }
//            public decimal AvgBudget { get; set; }
//            public decimal PredictedSaving => AvgBudget - AvgSpent;
//            // Stores (Month Name, Amount) for Chart X-Axis labels
//            public List<Tuple<string, decimal>> History { get; set; } = new List<Tuple<string, decimal>>();
//        }

//        public PredictionResult GetForecast(int accID, int targetMonth, int targetYear)
//        {
//            var result = new PredictionResult();
//            DateTime target = new DateTime(targetYear, targetMonth, 1);
//            decimal sumSpent = 0;
//            decimal sumBudget = 0;

//            // Solution A: Loop back 3 months (e.g., if predicting May, retrieve Feb, Mar, Apr)
//            for (int i = 3; i >= 1; i--)
//            {
//                DateTime pastDate = target.AddMonths(-i);
//                // Specifically query your 'transaction' table
//                var txs = _db.GetTransactions(accID, pastDate.Month, pastDate.Year);

//                decimal spent = _tLogic.GetTotalSpent(txs);
//                decimal budget = _tLogic.GetTotalBudget(txs);

//                result.History.Add(new Tuple<string, decimal>(pastDate.ToString("MMMM"), spent));

//                sumSpent += spent;
//                sumBudget += budget;
//            }

//            result.AvgSpent = sumSpent / 3;
//            result.AvgBudget = sumBudget / 3;
//            return result;
//        }
//    }
//}

namespace CentSible.Logic
{
    public class PredictionLogic
    {
        private TransactionDB _db = new TransactionDB();
        private TransactionLogic _tLogic = new TransactionLogic();

        public class PredictionResult
        {
            public decimal AvgSpent { get; set; }
            public decimal AvgBudget { get; set; }
            public decimal PredictedSaving => AvgBudget - AvgSpent;
            // Updated to store Month, Spent, and Budget for all 3 lines
            public List<MonthData> History { get; set; } = new List<MonthData>();
        }

        public class MonthData
        {
            public string MonthName { get; set; }
            public decimal Spent { get; set; }
            public decimal Budget { get; set; }
        }

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