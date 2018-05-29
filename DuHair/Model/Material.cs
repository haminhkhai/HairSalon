using DuHair;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuHair
{
    class Material
    {
        public Material()
        { 
            this.Services = new HashSet<Service>();
        }
        [Key]
        public int MaterialId { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int PriceBuy { get; set; }
        public float Discount { get; set; }
        public int NetWeight { get; set; }
        public string Unit { get; set; }
        public string Status { get; set; }
        public string ImageUrl { get; set; }
        public virtual ICollection<Service> Services { get; set; }
    }

    class MaterialRestockView
    {
        public int MaterialId { get; set; }
        public string Name { get; set; }
        public int PriceBuy { get; set; }
        public int Quantity { get; set; }
    }

    class MaterialSellView
    {
        public int MaterialId { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public float Discount { get; set; }
        public int Quantity { get; set; }
        public int Total { get; set; }
        public int SellComMoney { get; set; }
    }
}
