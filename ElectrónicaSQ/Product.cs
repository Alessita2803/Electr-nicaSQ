using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectrónicaSQ
{
    internal class Product
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public float Price { get; set; }
        public int Quantity { get; set; }
        public Product(string id, string name, string brand, float price, int quantity)
        {
            Id = id;
            Name = name.Trim();
            Brand = brand.Trim();
            Price = price;
            Quantity = quantity;
        }                        
    }
}
