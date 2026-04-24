using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentSible.Models
{
    public class MonthlySummary
    {
        public int SummaryID { get; set; }
        public int AccountID { get; set; }
        public string Month { get; set; }
        public int Year { get; set; }
        public decimal TotalIncome { get; set; }
        public decimal TotalExpense { get; set; }
        public decimal TotalSaving { get; set; }
    }
}
