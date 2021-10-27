using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson63_Named_parameters
{
    class Program
    {
        //Именованные параметры
        static int Sum(int a, int b, bool enableLogging = false)  
        {
            int result = a + b;
            if (enableLogging)
            {
                Console.WriteLine("Varuable a: " + a);
                Console.WriteLine("Varuable b: " + b);
                Console.WriteLine("Result:     " + result);
            }
            return result;
        }
        static void Main(string[] args)
        {

            Console.WriteLine("Result:     " + Sum(a: 5,b: 2, enableLogging: true)); //Именованные переменные  a:
        }

    }
}
