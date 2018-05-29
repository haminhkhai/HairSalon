using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuHair
{
    class SpendNote
    {
        [Key]
        public int SpendNoteId { get; set; }
        public string Name { get; set; }
        public int AmountMoney { get; set; }
        public bool Monthly { get; set; }
        public DateTime SpendDate { get; set; }
    }

    class SpendNoteView
    {
        public int SpendNoteId { get; set; }
        public string Name { get; set; }
        public int AmountMoney { get; set; }
        public bool Monthly { get; set; }
        public DateTime SpendDate { get; set; }
    }
}
