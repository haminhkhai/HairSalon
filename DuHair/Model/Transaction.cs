using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuHair
{
    class Transaction
    {
        [Key]
        public int TransactionId { get; set; }
        public int Amount { get; set; }
        public DateTime TransactionDate { get; set; }
        public Employee Casher { get; set; }
        public Customer Customer { get; set; }
        public bool IsDelete { get; set; }
        public virtual ICollection<TransactionService> TransactionServices { get; set; }
        public virtual ICollection<TransactionEmployee> TransactionEmployees { get; set; }
        public int PrintCount { get; set; }
        public bool IsPaidWithCash { get; set; }
    }

    class TransactionStatisticView
    {
        public int TransactionId { get; set; }
        public string TransactionIdCoded { get; set; }
        public string Name { get; set; }
        public int Amount { get; set; }
        public DateTime TransactionDate { get; set; }
        public Employee Casher { get; set; }
        public bool IsPaidWithCash { get; set; }
    }
}
