using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuHair
{
    class SellTranDetail
    {
        [Key]
        public int SellTranDetailId { get; set; }
        public SellTran SellTran { get; set; }
        public Material Material { get; set; }
        public float Discount { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
        public int SellComMoney { get; set; }
    }
}
