using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuHair
{
    class Employee 
    {
        public Employee()
        {
            this.Transactions = new HashSet<Transaction>();
        }
        [Key]
        public int EmployeeId { get; set; }
        public string Username { get; set; }
        public string Pwwd { get; set; }
        public string Name { get; set; }
        public string Tel { get; set; }
        public string Address { get; set; }
        public DateTime Birthday { get; set; }
        public int Wage { get; set; }
        public string Status { get; set; }
        public string Sex { get; set; }
        public string Role { get; set; }
        public string ImageUrl { get; set; }
        public virtual ICollection<Transaction> Transactions { get; set; }
    }

    class EmployeeTimeKeepingView
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public int Wage { get; set; }
        public float WorkedDay { get; set; }
        public float Overtime { get; set; }
        public int RealWage { get; set; }
    }
}
