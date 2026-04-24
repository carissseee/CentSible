using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace CentSible.Models
{
    public class Account
    {
        public int AccountID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int LoginStreak { get; set; }
        public int LongestStreak { get; set; }
        public DateTime? LastLoginDate { get; set; }
        public DateTime? CreatedAt { get; set; }

    }
}
