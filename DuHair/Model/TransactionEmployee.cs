using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuHair
{
    class TransactionEmployee
    {
        [Key, Column(Order = 0)]
        public int TransactionId { get; set; }
        [Key, Column(Order = 1)]
        public int EmployeeId { get; set; }
        public virtual Transaction Transaction { get; set; }
        public virtual Employee Employee { get; set; }
        public int DiscountMoney { get; set; }

    }
}
