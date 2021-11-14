using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson95_Polymorphism_virtual_override
{
    // Полиморфизм
    // виртуальные методы
    // virtual override 
    class Car
    {
        protected void StartEngine()
        {
            Console.WriteLine("Запускаем двигатель");
        }
        public virtual void Drive()
        {
            StartEngine();
            Console.WriteLine("Еду");
        }
    }
    class Sportcar: Car
    {
        public override void Drive()
        {
            StartEngine();
            // base.Drive();
            Console.WriteLine("Еду очень быстро");
        }
    }
    class Person // ключевой момент, что при этом мы не меняем класс Person
    {
        public void DriveCar(Car car)
        {
            car.Drive();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Car car = new Car();
            Person person = new Person();
            person.DriveCar(new Car());
            person.DriveCar(new Sportcar());
        }
    }
}
