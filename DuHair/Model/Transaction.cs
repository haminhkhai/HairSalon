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
        public Transaction()
        {
            this.Employees = new HashSet<Employee>();
            this.Services = new HashSet<Service>();
        }
        [Key]
        public int TransactionId { get; set; }
        public int Amount { get; set; }
        public string Note { get; set; }
        public DateTime TransactionDate { get; set; }
        public string BeforeImgUrl { get; set; }
        public string AfterImgUrl { get; set; }
        public int Status { get; set; }
        public Employee Casher { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<Service> Services { get; set; }
        public Customer Customer { get; set; }
        public Chair Chair { get; set; }
    }

    class TransactionStatisticView
    {
        public int TransactionId { get; set; }
        public string TransactionIdCoded { get; set; }
        public string Name { get; set; }
        public int ChairId { get; set; }
        public string ChairName { get; set; }
        public int Amount { get; set; }
        public DateTime TransactionDate { get; set; }
        public int Status { get; set; }
        public Employee Casher { get; set; }
    }
}
