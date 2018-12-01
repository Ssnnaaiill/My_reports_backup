using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kinew_Cs
{
    class _180725_1
    {
        static void randomClass(string[] args)
        {
            Random rand = new Random();
            for (int i = 0; i < 5; i++) Console.WriteLine(rand.NextDouble());
        }
    }
}
