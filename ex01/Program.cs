using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog spotty = new Dog();
            spotty.nume = "Beethoven";
            spotty.age = 4;
            spotty.happiness = 0.8f;
            spotty.spotCount = 25;
            spotty.baseAnimal();
            spotty.Bark();

            Cat heisenberg = new Cat();
            heisenberg.nume = "Heisenberg";
            heisenberg.age = 6;
            heisenberg.happiness = 0.8f;
            heisenberg.cuteness = 12.5f;
            heisenberg.baseAnimal();
            heisenberg.Meow();


            Console.ReadKey();
        }
    }
}
