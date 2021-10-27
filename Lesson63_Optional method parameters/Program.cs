using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson63_Optional_method_parameters
{
    // Необязательные параметры методов
    class Program
    {
        static int Sum (int a, int b, bool enableLogging = false) // Присваивание значение параметры сразу же при его объявлении делает его необязельным 
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

            Console.WriteLine("Result:     " + Sum(5, 2, true));
        }
    }
}
