using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuHair
{
    class TransactionService
    {
        [Key, Column(Order = 0)]
        public int TransactionId { get; set; }
        [Key, Column(Order = 1)]
        public int ServiceId { get; set; }
        public virtual Transaction Transaction { get; set; }
        public virtual Service Service { get; set; }
        public int Quantity { get; set; }
        public int Price2 { get; set; }
    }
}
