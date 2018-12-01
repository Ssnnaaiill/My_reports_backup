using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kinew_Cs
{
    class _180724_6
    {
        static void __for_gaus_KoreanCharacters(string[] args)
        {
            int sum = 0;
            for (int i = 1; i <= 100; i++) sum += i;
            Console.WriteLine(sum);
            for (char i = '가'; i <= '힣'; i++) Console.Write(i);
        }
    }
}
