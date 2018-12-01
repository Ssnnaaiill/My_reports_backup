using System;

namespace kinew_Cs
{
    class _180724_2
    {
        static void BasicRules2(string[] args)
        {
            uint unsignedint = 4147483647;
            ulong unsignedlong = 11233720368454775808;
            Console.WriteLine(unsignedint);
            Console.WriteLine(unsignedlong);
            Console.WriteLine(int.MinValue + " ~ " + int.MaxValue);
            Console.WriteLine(long.MinValue + " ~ " + long.MaxValue);

            char a = 'a', b = 'b';
            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
            Console.WriteLine(a * b);
            Console.WriteLine(a / b);
            Console.WriteLine(a % b);
        }
    }
}
