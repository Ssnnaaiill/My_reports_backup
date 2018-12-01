using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kinew_Cs
{
    class _180731_2
    {
        class Parent
        {
            public int variable = 273;
            public virtual void Method() { Console.WriteLine("Parent's method"); }
        }
        class Child : Parent
        {
            public new string variable = "shadowing";
            public override void Method() { Console.WriteLine("Child's method"); }
        }
        static void fuckingTwitter(string[] args)
        {
            Console.WriteLine(new Child().variable);
            Console.WriteLine(((Parent)new Child()).variable);
            new Child().Method();
            ((Parent)new Child()).Method();
        }
    }
}