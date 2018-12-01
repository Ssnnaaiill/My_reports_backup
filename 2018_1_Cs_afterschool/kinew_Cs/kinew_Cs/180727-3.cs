using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kinew_Cs
{
    class _180727_3
    {
        static int Power(int input) => input * input;
        static int Power(int input, int cnt) => new int[cnt]
            .Select(x => input)
            .Aggregate((n, m) => n * m);
        static int sumAll(int end) => Enumerable.Range(0, end + 1).Sum();
        static int sumAll(int st, int end) => Enumerable.Range(st, end - st + 1).Sum();
        static void calculateFairy(string[] args)
        {
            Console.WriteLine(Power(500));
            Console.WriteLine(Power(2, 10));
            Console.WriteLine(sumAll(100));
            Console.WriteLine(sumAll(1, 10));
        }
    }
}