using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentSible.Models
{
    public class Budget
    {
        public int BudgetID { get; set; }
        public int AccountID { get; set; }
        public decimal MonthlyLimit { get; set; }
        public string Month { get; set; }
        public int Year { get; set; }
    }
}
