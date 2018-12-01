using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kinew_Cs
{
    class _180803_3
    {
        class Product
        {
            public string Name { get; set; }
            public int Price { get; set; }

        }
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>()
            {
                new Product { Name = "고구마", Price = 1500 },
                new Product { Name = "사과", Price = 2400 },
                new Product { Name = "바나나", Price = 1000 },
                new Product { Name = "배", Price = 3000 },
                new Product { Name = "감자", Price = 1000 },
                new Product { Name = "토마토", Price = 2000 },
                new Product { Name = "옥수수", Price = 1500 },
                new Product { Name = "자두", Price = 500 }
            };
            /*
             * var output = from item in products
             * where item.Price > 1500
             * orderby item.Name
             * select item;
             */
            var output = products.Where(item => item.Price > 1500).OrderBy(item => item.Price);
            foreach (var item in output) { Console.WriteLine(item.Name + ":" + item.Price); }
        }
    }
}