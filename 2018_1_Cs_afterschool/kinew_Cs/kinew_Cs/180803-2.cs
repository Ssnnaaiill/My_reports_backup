using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kinew_Cs
{
    class _180803_2
    {
        static void LinQExample(string[] args)
        {
            List<int> input = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            /*var output = from item in input
                         where item % 2 == 0
                         orderby item
                         select item * item;*/

            /*var output = from item in input
                         where item > 5
                         where item % 2 == 0
                         orderby item descending
                         select item;*/
            var output = from item in input
                         where item % 2 == 0
                         select new
                         {
                             A = item + 2,
                             B = item + item,
                             C = 95623
                         };

            foreach (var item in output) { Console.WriteLine(item.A + "," + item.B + "," + item.C); }
        }
    }
}