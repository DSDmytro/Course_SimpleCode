using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1st number");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter 2nd number");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter 3rd number");
            double c = double.Parse(Console.ReadLine());
            double sumResult = a + b + c;
            Console.WriteLine("Result: " + sumResult);
            double multResult = a * b * c;
            Console.WriteLine("Result: " + multResult);
        }
    }
}
