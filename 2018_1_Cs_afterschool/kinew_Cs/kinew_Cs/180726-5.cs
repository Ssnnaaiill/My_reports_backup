using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kinew_Cs
{
    class _180726_5
    {
        class Product
        {
            public int price;
            public string name;

            public Product(int price, string name)
            {
                this.price = price;
                this.name = name;
            }
        }
        static void ConstructorExample(string[] args)
        {
            Random r = new Random();
            List<Product> product = new List<Product>();
            product.Add(new Product(r.Next(), "감자"));
            product.Add(new Product(r.Next(), "고구마"));
            foreach (Product item in product) Console.WriteLine(item.price + ":" + item.name);
            Console.WriteLine(product.Count + "개 생성되었습니다.");
        }
    }
}