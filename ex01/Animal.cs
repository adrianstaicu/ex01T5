using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex01
{
    class Animal
    {
        public string nume;
        public int age;
        public float happiness;

        public void baseAnimal()
        {
            Console.WriteLine("Name:" + nume);
            Console.WriteLine("Age:" + age);
            Console.WriteLine("Happiness: " + happiness);
        }

    }

    class Dog : Animal
    {
        public int spotCount;
        public void Bark()
        {
            Console.WriteLine("WUF");
        }
    }
    class Cat : Animal 
    {
        public float cuteness;
        public void Meow()
        {
            Console.WriteLine("Meow");
        }
    }

}
