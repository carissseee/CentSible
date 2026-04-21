using System;

namespace CentSible.Models
{
    public class Account
    {
        public int AccountID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public DateTime CreatedAt { get; set; }
        public int CurrentStreak { get; set; }
        public int HighestStreak { get; set; }
        public DateTime LastLogin { get; set; }
    }
}