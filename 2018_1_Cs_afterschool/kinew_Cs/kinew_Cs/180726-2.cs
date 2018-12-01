using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kinew_Cs
{
    class _180726_2
    {
        class Subject
        {
            public int Gauss(int min, int max)
            {
                int sum = 0;
                for (int i = min; i <= max; i++) sum += i;
                return sum;
            }
        }
        static void mintomaxtest(string[] args)
        {
            Subject subject = new Subject();
            Console.WriteLine(subject.Gauss(1, 100));
        }
    }
}