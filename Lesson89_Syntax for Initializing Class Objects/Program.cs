using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson89_Syntax_for_Initializing_Class_Objects
{
    // Синтаксис инициализации объектов класса
    class Cat
    {
        public int Age { get; set; }
        public string Name { get; set; }

        public Cat()
        {

        }

        public Cat(string name)
        {
            Name = name;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat1 = new Cat();
            cat1.Age = 5;
            cat1.Name = "Murka";
            Console.WriteLine("Cat 1: " + "Age = "+ cat1.Age + " " + "Name = " + cat1.Name);

            Cat cat2 = new Cat 
            { 
                Age = 3, 
                Name = "Luna" 
            };
            Console.WriteLine("Cat 2: " + "Age = " + cat2.Age + " " + "Name = " + cat2.Name);

            Cat cat3 = new Cat("Barsik");
            cat3.Age = 4;
            Console.WriteLine("Cat 3: " + "Age = " + cat3.Age + " " + "Name = " + cat3.Name);

            Cat cat4 = new Cat("Beta")
            {
                Age = 5
            };
            Console.WriteLine("Cat 4: " + "Age = " + cat4.Age + " " + "Name = " + cat4.Name);

        }
    }
}
