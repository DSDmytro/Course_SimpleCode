using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson17_logical_operators
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isInfected = false;
            if (!isInfected)
            {
                Console.WriteLine("The Character is Healty");
            }

            Console.WriteLine("Enter FanSpeed:");
            int fanspeed = int.Parse(Console.ReadLine());
            bool hightemp = true;
            bool cooling = fanspeed <= 100;
            if (hightemp && cooling)
            {
                Console.WriteLine("Danger!");
            }
            else
            {
                Console.WriteLine("Temperature is Ok!");
            }
        }
    }
}
