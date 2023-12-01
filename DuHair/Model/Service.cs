using DuHair;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuHair
{
    class Service
    {
        public Service()
        {
            this.Materials = new HashSet<Material>();
        }
        [Key]
        public int ServiceId { get; set; }
        public int Order { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public float Discount { get; set; }
        public float SellDiscount { get; set; }
        public string Status { get; set; }
        public virtual ICollection<Material> Materials { get; set; }
        public virtual ICollection<TransactionService> TransactionServices { get; set; }
    }

    public class ServiceView
    {
        public int ServiceId { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
        public float Discount { get; set; }
    }

    public class ServiceBill
    {
        public int ServiceId { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
        public int Total { get; set; }
    }
}
