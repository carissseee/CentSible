using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentSible.Models
{
    public enum GoalCategory
    {
        Spending,
        Savings
    }
    public class Goal
    {
        public int GoalID { get; set; }
        public int AccountID { get; set; }
        public GoalCategory GoalType { get; set; }
        public decimal TargetAmount { get; set; }
        public decimal CurrentAmount { get; set; }
        public DateTime TargetDate { get; set; }
    }
}