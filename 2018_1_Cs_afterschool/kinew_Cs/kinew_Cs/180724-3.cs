using System;

namespace kinew_Cs
{
    class _180724_3
    {
        static void ReadnWrite(string[] args)
        {
            Console.Write("inch\t: ");      // inch --> cm
            double inch = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("cm\t: " + inch * 2.54);
            Console.WriteLine();
            
            Console.Write("kg\t: ");        // kg --> pounds
            double kg = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("pounds\t: " + kg * 2.20462);
            Console.WriteLine();

            Console.Write("radius\t: ");    // radius --> round, area
            double r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("round\t: " + r * 2 * 3.14);
            Console.WriteLine("area\t: " + r * r * 3.14);
            Console.WriteLine();
        }
    }
}