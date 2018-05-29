using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuHair
{
    class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string Tel { get; set; }
        public DateTime Birthday { get; set; }
        public int Point { get; set; }
        public string Status { get; set; }
        public string Sex { get; set; }
        public string ImageUrl { get; set; }
    }
}
