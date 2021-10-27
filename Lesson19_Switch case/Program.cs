using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson19_Switch_case
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            switch (a)
            {
                case 1:
                    Console.WriteLine("Number: 1");
                    break;
                case 2:
                    Console.WriteLine("Number: 2");
                    break;
                case 3:
                case 4:
                    Console.WriteLine("Number: 3 or 4");
                    break;
                default:
                    Console.WriteLine("Another number");
                    break;
            }
            string b = Console.ReadLine();
            switch (b)
            {
                case "+":
                    Console.WriteLine("You input +");
                    break;
                case "-":
                    Console.WriteLine("You input -");
                    break;
            }
        }
    }
}
