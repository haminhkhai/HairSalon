using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuHair
{
    class TkDetail
    {
        [Key]
        public int TkDetailId { get; set; }
        public TimeKeeping TimeKeeping { get; set; }
        public Employee Employee { get; set; }
        public float WorkedDay { get; set; }
        public float Overtime { get; set; }
        public int RealWage { get; set; }
    }
}
