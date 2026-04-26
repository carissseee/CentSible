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
    public class AccountLogic
    {
        private AccountDB db = new AccountDB();

        public class StreakMetrics
        {
            public int CurrentStreak { get; set; }
            public int LongestStreak { get; set; }
            public int MaxGoal { get; set; } = 30;
            public string StreakText { get; set; }
            public Color StatusColor { get; set; }
            public bool IsMaster { get; set; }
        }

        public Account GetAuthenticatedUser(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
                throw new Exception("Please enter both username and password.");

            Account user = db.GetAccount(username, password);
            if (user != null)
            {
                int newStreak = CalculateStreak(user.LastLoginDate, user.LoginStreak);
                int newLongest = (newStreak > user.LongestStreak) ? newStreak : user.LongestStreak;
                user.LoginStreak = newStreak;
                user.LongestStreak = newLongest;
                db.UpdateStreakAndDate(user.AccountID, newStreak, newLongest);
                return user;
            }
            return null;
        }

        public void RegisterUser(string username, string password, string confirm)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
                throw new Exception("All fields are required.");
            if (password != confirm) throw new Exception("Passwords do not match.");
            db.RegisterAccount(username, password);
        }

        public StreakMetrics GetStreakMetrics(Account user)
        {
            if (user == null) return new StreakMetrics();
            int max = 30;
            bool mastered = user.LongestStreak >= max;
            return new StreakMetrics
            {
                CurrentStreak = user.LoginStreak,
                LongestStreak = user.LongestStreak,
                IsMaster = mastered,
                StatusColor = mastered ? Color.Gold : Color.OrangeRed,
                StreakText = mastered ? $"MONTHLY MASTER: {user.LongestStreak} Days" : $"Record: {user.LongestStreak}/{max} to Mastery"
            };
        }

        private int CalculateStreak(DateTime? lastLogin, int currentStreak)
        {
            if (lastLogin == null) return 1;
            double days = (DateTime.Today - lastLogin.Value.Date).TotalDays;
            if (days == 1) return currentStreak + 1;
            if (days == 0) return currentStreak;
            return 1;
        }
    }
}