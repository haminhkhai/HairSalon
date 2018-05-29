using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuHair
{
    class Warehouse
    {
        [Key]
        public int WarehouseId { get; set; }
        public Material Material { get; set; }
        public int Quantity { get; set; }
    }

    class WarehouseCheckDetailView
    {
        public Material Material { get; set; }
        public int OldQuantity { get; set; }
        public int Quantity { get; set; }
    }
}
