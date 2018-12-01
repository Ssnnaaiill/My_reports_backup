using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kinew_Cs
{
    class _180727_2
    {   
        static void Death__HigHnLoW___GAme(string[] args)
        {
            int answer = new Random().Next(), guess, life = 50;
            while(life > 0)
            {
                Console.Write("Insert Integer value >>> ");
                guess = Convert.ToInt32(Console.ReadLine());
                if (answer < guess) Console.WriteLine("# Lower");
                else if (answer > guess) Console.WriteLine("# Higher");
                else { Console.WriteLine("# Correct!"); break; }
                life--;
            }
            Console.WriteLine((life <= 0) ? "You've died. Too Bad :(" : "Congratulations! :D");
            Console.WriteLine("Life : " + life);
        }
    }
}