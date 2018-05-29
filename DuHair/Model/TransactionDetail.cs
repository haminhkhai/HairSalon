using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuHair.Model
{
    class TransactionDetail
    {
        public int TransactionDetailId { get; set; }
        public Transaction Transaction { get; set; }
        public Service Service { get; set; }
        public int Quantity { get; set; }
    }
}
