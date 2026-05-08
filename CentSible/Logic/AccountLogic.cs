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

     
        public Account GetAuthenticatedUser(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                throw new Exception("Please enter both username and password.");
            }


            Account user = db.GetAccount(username);

            if (user == null) 
            {
                return null;
            }

            if (!BCrypt.Net.BCrypt.Verify(password, user.Password))
            {
                return null;
            }

            int newStreak = CalculateStreak(user.LastLoginDate, user.LoginStreak);
            int newLongest = (newStreak > user.LongestStreak) ? newStreak : user.LongestStreak;
            user.LoginStreak = newStreak;
            user.LongestStreak = newLongest;
            db.UpdateStreakAndDate(user.AccountID, newStreak, newLongest);
            return user;
        }

   
        public void RegisterUser(string username, string password, string confirm)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(confirm))
            {
                throw new Exception("All fields are required.");
            }

            if (username.Trim().Length < 3 || username.Trim().Length > 12)
            {
                throw new Exception("Username must be between 3 and 12 characters.");
            }
            if (password.Length < 5 || password.Length > 12)
            {
                throw new Exception("Password must be between 5 and 12 characters.");
            }
            if (password != confirm)
            {
                throw new Exception("Passwords do not match.");
            }

            Account newUser = new Account
            {
                Username = username.Trim(),
                Password = BCrypt.Net.BCrypt.HashPassword(password),
                LoginStreak = 0,
                LongestStreak = 0
            };

            db.RegisterAccount(newUser);

        }

        public StreakMetrics GetStreakMetrics(Account user)
        {
            if (user == null)
            {
                return new StreakMetrics();
            }
            int max = 365;
            bool mastered = user.LongestStreak >= max;
            return new StreakMetrics
            {
                CurrentStreak = user.LoginStreak,
                LongestStreak = user.LongestStreak,
                IsMaster = mastered,       
                StatusColor = GetMilestoneColor(user.LongestStreak),
                StreakText = mastered ? $"MONTHLY MASTER: {user.LongestStreak} Days" : $"Record: {user.LongestStreak}/{max} to Mastery"
            };
        }

        private Color GetMilestoneColor(int longestStreak)
        {
            if (longestStreak >= 250) 
            { 
                return Color.DarkBlue; 
            }
            if (longestStreak >= 100) 
            { 
                return Color.Blue; 
            }
            if (longestStreak >= 30) 
            { 
                return Color.Teal; 
            }
            return Color.FromArgb(62, 153, 66); 
        }

        private int CalculateStreak(DateTime? lastLogin, int currentStreak)
        {
            if (lastLogin == null)
            {
                return 1;
            }
            double days = (DateTime.Today - lastLogin.Value.Date).TotalDays;
            if (days == 1)
            {
                return currentStreak + 1;
            }
            if (days == 0)
            {
                return currentStreak;
            }
            return 1;
        }
    }
}