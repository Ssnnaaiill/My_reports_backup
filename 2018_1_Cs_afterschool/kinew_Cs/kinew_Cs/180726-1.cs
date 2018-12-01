using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kinew_Cs
{
    class _180726_1
    {
        class Test { public int Power(int x) { return x * x; } }
        static void MethodTest(string[] args)
        {
            Test test = new Test();
            Console.WriteLine(test.Power(10) + "\n" + test.Power(20));
        }
    }
}