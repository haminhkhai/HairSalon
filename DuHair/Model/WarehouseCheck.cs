using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuHair
{
    class WarehouseCheck
    {
        [Key]
        public int WarehouseCheckId { get; set; }
        public int Margin { get; set; }
        public string Note { get; set; }
        public DateTime CheckDate { get; set; }
    }

    class WarehouseCheckView
    {
        public int WarehouseCheckId { get; set; }
        public string WarehouseCheckIdCoded { get; set; }
        public int Margin { get; set; }
        public DateTime CheckDate { get; set; }
    }
}
