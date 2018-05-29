using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuHair
{
    class RestockDetail
    {
        [Key]
        public int RestockDetailId { get; set; }
        public Restock Restock { get; set; }
        public Material Material { get; set; }
        public int Quantity { get; set; }
        public int PriceBuy { get; set; }
    }
}
