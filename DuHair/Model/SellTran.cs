using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuHair
{
    class SellTran
    {
        [Key]
        public int SellTranId { get; set; }
        public Customer Customer { get; set; }
        public Employee Employee { get; set; }
        public Employee Casher { get; set; }
        public int Amount { get; set; }
        public DateTime SellDate { get; set; }
    }

    class SellTranView
    {
        public string SellTranIdCoded { get; set; }
        public int SellTranId { get; set; }
        public string CustomerName { get; set; }
        public string EmployeeName { get; set; }
        public string CasherName { get; set; }
        public int Amount { get; set; }
        public int TotalDiscountMoney { get; set; }
        public DateTime SellDate { get; set; }
    }
}
