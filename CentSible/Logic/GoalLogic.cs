using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CentSible.Models;
using CentSible.Database;
using System.Drawing;

namespace CentSible.Logic
{
    public class GoalLogic
    {
        private GoalDB _db = new GoalDB();

        public class GoalDisplayMetrics
        {
            public int TotalPercent { get; set; }
            public int MilestoneStep { get; set; }
            public string StatusNote { get; set; }
            public Color ThemeColor { get; set; }
            public string DaysText { get; set; }
            public string AmountText { get; set; }
        }

        public bool ProcessGoalEntry(int accountId, GoalCategory type, double target, double current, DateTime date)
        {
            
            if (target <= 0) throw new Exception("Target amount must be a positive value.");

            
            Goal goalModel = new Goal
            {
                AccountID = accountId,
                GoalType = type,
                TargetAmount = target,
                CurrentAmount = current,
                TargetDate = date
            };

            
            var existing = _db.GetGoalsByPeriod(accountId, date.Month, date.Year)
                              .Find(x => x.GoalType == type);

            
            return existing != null ? _db.UpdateGoal(goalModel) : _db.AddGoal(goalModel);
        }

        public GoalDisplayMetrics GetCalculatedMetrics(Goal goal)
        {
            if (goal == null) return null;
            double rawPercent = (goal.TargetAmount > 0) ? (goal.CurrentAmount / goal.TargetAmount) * 100 : 0;
            int cappedPercent = (int)Math.Min(rawPercent, 100);
            int days = (goal.TargetDate.Date - DateTime.Today).Days;
            bool isSpending = goal.GoalType == GoalCategory.Spending;

            return new GoalDisplayMetrics
            {
                TotalPercent = cappedPercent,
                MilestoneStep = CalculateMilestoneStep(rawPercent),
                StatusNote = GetStatusNote(rawPercent, isSpending),
                ThemeColor = isSpending ? Color.Crimson : Color.ForestGreen,
                DaysText = days >= 0 ? $"{days} Days to Go" : "Overdue",
                AmountText = $"₱ {goal.CurrentAmount:N0} / ₱ {goal.TargetAmount:N0}"
            };
        }

        private int CalculateMilestoneStep(double percent)
        {
            if (percent >= 100) return 100;
            if (percent >= 80) return 80;
            if (percent >= 60) return 60;
            if (percent >= 40) return 40;
            if (percent >= 20) return 20;
            return 0;
        }

        private string GetStatusNote(double percent, bool isSpending)
        {
            if (percent >= 100) return isSpending ? "STOP! Limit reached." : "Success! Goal achieved.";
            if (percent >= 75) return isSpending ? "DANGER: Almost at the limit!" : "Final stretch! Almost there.";
            if (percent >= 50) return isSpending ? "Warning: Half of budget used." : "Halfway! Keep it up.";
            return isSpending ? "Safe: Well within limit." : "Every peso counts!";
        }

        public List<Goal> GetGoals(int id, int m, int y) => _db.GetGoalsByPeriod(id, m, y);
    }
}