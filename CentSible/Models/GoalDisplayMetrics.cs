using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace CentSible.Models
{
    public class GoalDisplayMetrics
    {
        public int TotalPercent { get; set; }
        public int MilestoneStep { get; set; }
        public string StatusNote { get; set; }
        public Color ThemeColor { get; set; }
        public string DaysText { get; set; }
        public string AmountText { get; set; }
    }
}