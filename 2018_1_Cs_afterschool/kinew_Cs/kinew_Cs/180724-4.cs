using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kinew_Cs
{
    class _180724_4
    {
        static void type2type(string[] args)
        {
            Console.WriteLine((273).GetType());
            Console.WriteLine((522731033265L).GetType());
            Console.WriteLine((52.273F).GetType());
            Console.WriteLine((52.273).GetType());
            Console.WriteLine(('자').GetType());
            Console.WriteLine(("문자열").GetType());

            int a = 2147483647;
            long int2long = a;
            Console.WriteLine(int2long);
            double int2double = a;
            Console.WriteLine(int2double);
            Console.WriteLine(int.Parse("52"));
        }
    }
}
