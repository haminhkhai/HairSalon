using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuHair
{
    class TimeKeeping
    {
        [Key]
        public int TimeKeepingId { get; set; }
        public string MonthAndYear { get; set; }
        public float WorkingDay { get; set; }
    }

    class TimeKeepingView
    {
        public int TimeKeepingId { get; set; }
        public string MonthAndYear { get; set; }
        public float WorkingDay { get; set; }
    }
}
