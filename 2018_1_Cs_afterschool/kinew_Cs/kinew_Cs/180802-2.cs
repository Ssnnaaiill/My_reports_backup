using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kinew_Cs
{
    class _180802_2
    {
        static void ExceptionExample___2(string[] args)
        {
            Console.Write("input : ");
            string input = Console.ReadLine();
            try
            {
                int index = int.Parse(input);
                Console.WriteLine("input number : " + index);
            }
            catch(Exception exception)
            {
                Console.WriteLine("exception");
                Console.WriteLine(exception.GetType());
                Console.WriteLine(exception.Message);
                Console.WriteLine(exception.StackTrace);

            } 
        }
    }
}
