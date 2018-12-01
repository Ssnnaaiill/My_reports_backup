using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kinew_Cs
{
    class _180801_1
    {
        class Product:IComparable
        {
            public string Name { get; set; }
            public int Price { get; set; }

            public int CompareTo(object obj)
            {
                //throw new NotImplementedException();
                return this.Price.CompareTo((obj as Product).Price);
            }
            public override string ToString() { return Name + ":" + Price + "\\"; }
        }
        static void U__r__GOGUMa(string[] args)
        {
            List<Product> list = new List<Product>()
            {
                new Product() { Name = "고구마50", Price = 50 },
                new Product() { Name = "고구마1", Price = 1 },
                new Product() { Name = "고구마3", Price = 3 },
                new Product() { Name = "고구마2", Price = 2 }
            };
            list.Sort();
        }
    }
}