using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Webshop.Models
{
    public class Shopitem
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int QuantityOfStock { get; set; }

        public Shopitem(string name, string description, double price, int quantityOfStock)
        {
            this.Name = name;
            this.Description = description;
            this.Price = price;
            this.QuantityOfStock = quantityOfStock;
        }
    }
}
