using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentSible.Models
{
    public class PredictionResult
    {
        public decimal AvgSpent { get; set; }
        public decimal AvgBudget { get; set; }
        public decimal PredictedSaving => AvgBudget - AvgSpent;

        public List<MonthData> History { get; set; } = new List<MonthData>();
    }

    public class MonthData
    {
        public string MonthName { get; set; }
        public decimal Spent { get; set; }
        public decimal Budget { get; set; }
    }
}