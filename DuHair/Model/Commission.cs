using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuHair
{
    class Commission
    {
        [Key]
        public int CommissionId { get; set; }
        public Transaction Transaction { get; set; }
        public Service Service { get; set; }
        public int Quantity { get; set; }
        public Employee Employee { get; set; }
        public float CommissionPercent { get; set; }
        public int ComMoney { get; set; }
        public int SellComMoney { get; set; }
        public int DiscountType { get; set; } //0:tien 1:%
        public string ComType { get; set; }
        public int OtherPrice { get; set; }
    }

    class CommissionView
    {
        public int CommissionId { get; set; }
        public Transaction Transaction { get; set; }
        public Service Service { get; set; }
        public int Quantity { get; set; }
        public Employee Employee { get; set; }
        public float CommissionPercent { get; set; }
        public int ComMoney { get; set; }
        public int SellComMoney { get; set; }
        public int DiscountType { get; set; } //0:tien 1:%
        public string ComType { get; set; }
        public int OtherPrice { get; set; }
    }

    class CommissionStatisticView
    {
        public string ServiceName { get; set; }
        public int Quantity { get; set; }
        public int EmployeeId { get; set; }
        public int ComMoney { get; set; }
        public int SellComMoney { get; set; }
        public string ComType { get; set; }
        public int OtherPrice { get; set; }
    }
}
