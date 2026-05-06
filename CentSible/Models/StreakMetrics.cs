using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CentSible.Models
{
    public class StreakMetrics
    {
        public int CurrentStreak { get; set; }
        public int LongestStreak { get; set; }
        public int MaxGoal { get; set; } = 30;
        public string StreakText { get; set; }
        public Color StatusColor { get; set; }
        public bool IsMaster { get; set; }
    }
}
