using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kinew_Cs
{
    class _180730_1
    {
        class Animal
        {
            public int Age { get; set; }
            public Animal() { this.Age = 0; }
            public void Eat() { Console.WriteLine("Eats it's meal."); }
            public void Sleep() { Console.WriteLine("Sleeps without a snore."); }
        }
        class Dog : Animal
        {
            public string Color { get; set; }
            public void Bark() { Console.WriteLine("Barks towards the stranger."); }
        }
        class Cat : Animal
        {
            public void Meow() { Console.WriteLine("Meows towards the stranger."); }
        }

        static void AnimalFarmExample(string[] args)
        {
            List<Animal> animals = new List<Animal> { new Dog(), new Cat() };
            foreach(var item in animals)
            {
                item.Eat();
                item.Sleep();
                /*if(item is Dog) { ((Dog)item).Bark(); }
                if(item is Cat) { ((Cat)item).Meow(); }*/
                var dog = item as Dog;
                if (dog != null) dog.Bark();
                var cat = item as Cat;
                if (cat != null) cat.Meow();
            }
        }
    }
}