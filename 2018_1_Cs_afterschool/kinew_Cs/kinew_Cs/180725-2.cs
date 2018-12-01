using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kinew_Cs
{
    class _180725_2
    {

        static void randomList(string[] args)
        {
            List<int> list = new List<int>();
            Random rand = new Random();
            for (int i = 0; i < rand.Next(50504, 50505); i++) list.Add(rand.Next() * 3);
            foreach (var item in list) Console.WriteLine("Count : " + list.Count + "\tItem : " + item);
        }
    }
}