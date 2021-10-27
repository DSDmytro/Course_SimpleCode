using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson46_Methods
{
    class Program
    {
        static int Sum (int a, int b) //метод    модификатор тип_возвращаемого_значения имя_метода (параметры)
        {
            int result = a + b;
            return result;
            // return a + b;    //краткий способ
        }

        static void PrintResult (int result)
        {
            Console.WriteLine("Sum: "+result);
        }

        static void Main(string[] args)
        {
            int a, b, c;
            Console.Write("Enter 1st value: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Enter 2nd value: ");
            b = int.Parse(Console.ReadLine());
            c = Sum(a, b);
            Console.WriteLine("Sum: "+ c);
            PrintResult(c);
        }
    }
}
