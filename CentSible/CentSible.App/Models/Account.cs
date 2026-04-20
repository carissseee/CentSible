using System;

namespace CentSible.Models
{
    public class Account
    {
        public int AccountID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public Date CreatedAt { get; set; }
        public int CurrentStreak { get; set; }
        public int HighestStreak { get; set; }
        public Date LastLogin { get; set; }
    }
}