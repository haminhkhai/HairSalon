using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuHair
{
    class WarehouseCheckDetail
    {
        [Key]
        public int WarehouseCheckDetailId { get; set; }
        public WarehouseCheck WarehouseCheck { get; set; }
        public Material Material { get; set; }
        public int OldQuantity { get; set; }
        public int Quantity { get; set; }
        public int Margin { get; set; }
    }
}
