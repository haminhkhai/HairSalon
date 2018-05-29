using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuHair
{
    class Restock
    {
        public int RestockId { get; set; }
        public int AmountMoney { get; set; }
        public DateTime RestockDate { get; set; }
    }

    class RestockView
    {
        public int RestockId { get; set; }
        public string RestockIdCoded { get; set; }
        public int AmountMoney { get; set; }
        public DateTime RestockDate { get; set; }
    }
}
