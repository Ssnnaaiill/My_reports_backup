using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kinew_Cs
{
    class _180731_3
    {
        class Animal { public virtual void Eat() { Console.WriteLine("Animal"); } }
        class Dog:Animal { public override void Eat() { Console.WriteLine("Dog"); } }
        class Cat : Animal { public override void Eat() { Console.WriteLine("Cat"); } }
        static void bowoMewo(string[] args)
        {
            List<Animal> animals = new List<Animal>() { new Dog(), new Cat(), new Cat(), new Dog(), new Dog(), new Cat(), new Dog(), new Dog() };
            foreach (var items in animals) items.Eat();
        }
    }
}