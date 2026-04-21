using System;

namespace CentSible.Models
{
    public enum GoalType
    {
        Saving,
        Sepnding
    }

    public class Goal
    {
        public int GoalId { get; set; }
        public int AccountID { get; set; }
        public GoalType GoalType { get; set; }
        public decimal TargetAmount { get; set; }
        public decimal CurrentAmount { get; set; }
        public DateTime TargetDate { get; set; }
    }
}