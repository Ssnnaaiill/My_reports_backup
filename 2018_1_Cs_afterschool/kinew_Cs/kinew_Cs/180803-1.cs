using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kinew_Cs
{
    class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }
        
    }
    class _180803_1
    {
        static void Delegate_and_Lambda (string[] args)
        {
            List<Product> products = new List<Product>()
            {
            new Product { Name = "a", Price = 100 },
            new Product { Name = "b", Price = 2 },
            new Product { Name = "c", Price = 30 },
            new Product { Name = "d", Price = 41 }
            };
            // products.Sort(delegate (Product a, Product b) { return a.Price.CompareTo(b.Price); });
            products.Sort((a, b) => { return a.Price.CompareTo(b.Price); });
            foreach (var item in products) Console.WriteLine(item.Name + ":" + item.Price);
        }
    }
}