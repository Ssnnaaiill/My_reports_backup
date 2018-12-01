using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kinew_Cs
{
    class _180726_4
    {
        class MyMath
        {
            public static int Abs(int input)
            {
                if (input < 0) return -input;
                else return input;
            }
            public static double Abs(double input)
            {
                if (input < 0) return -input;
                else return input;
            }
        }
        static void MethodOverridingTest(string[] args)
        {
            Console.WriteLine(MyMath.Abs(Convert.ToInt32(Console.ReadLine())));
            Console.WriteLine(MyMath.Abs(Convert.ToDouble(Console.ReadLine())));
        }
    }
}