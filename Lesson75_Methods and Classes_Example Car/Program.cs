using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson75_Methods_and_Classes_Example_Car
{
    class Car
    {
        private int speed = 0;
        public void PrintSpeed()
        {
            if (speed == 0)
            {
                Console.WriteLine("Стоим на месте");
            }
            if (speed > 0)
            {
                Console.WriteLine($"Едем вперед со скоростью {speed} км/ч");
            }
            if (speed < 0)
            {
                Console.WriteLine($"Едем назад со скоростью {-speed} км/ч");
            }
        }
        public void DriveForward()
        {
            speed = 60;
        }

        public void Stop()
        {
            speed = 0;
        }
        public void DriveBackward()
        {
            speed = -5;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine( " == Car 1 == ");
            var Car1 = new Car();
            Car1.PrintSpeed();
            Car1.DriveForward();
            Car1.PrintSpeed();
            Car1.Stop();
            Car1.PrintSpeed();
            Console.WriteLine();
            Console.WriteLine(" == Car 2 == ");
            var Car2 = new Car();
            Car2.PrintSpeed();
            Car2.DriveForward();
            Car2.PrintSpeed();
            Car2.Stop();
            Car2.PrintSpeed();
            Car2.DriveBackward();
            Car2.PrintSpeed();
        }
    }
}
