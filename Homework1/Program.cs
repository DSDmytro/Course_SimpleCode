using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1st number");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter 2nd number");
            double b = double.Parse(Console.ReadLine());
            double c = (a + b) / 2;
            Console.WriteLine("Result: " + c);
        }
    }
}
