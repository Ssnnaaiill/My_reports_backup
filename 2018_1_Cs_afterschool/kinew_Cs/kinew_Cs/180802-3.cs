using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kinew_Cs
{
    class _180802_3
    {
        static void ExceptionExample3(string[] args)
        {
            try
            {
                Console.Write("input integer number : ");
                string input = Console.ReadLine();
                int[] arr = { 52, 273, 32, 103 };
                int index = int.Parse(input);
                Console.WriteLine("input number : " + index);
                Console.WriteLine("array number : " + arr[index]);
            }
            catch(FormatException e)
            {
                Console.WriteLine("====================FormatxException====================");
                Console.WriteLine(e.GetType());
            }
            catch(IndexOutOfRangeException e)
            {
                Console.WriteLine("====================IndexOutofRangeException====================");
                Console.WriteLine(e.GetType());
            }
        }
    }
}