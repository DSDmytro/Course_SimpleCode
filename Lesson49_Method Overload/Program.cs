using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson49_Method_Overload
{
    class Program
    {
        /// <summary>
        /// Возвращает сумму 2 целых чисел
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        static int Sum(int a, int b)
        {
            int result = a + b;
            return result;
        }

        /// <summary>
        /// Возвращает сумму 3 целых чисел 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        static int Sum(int a, int b, int c)
        {
            int result = a + b + c;
            return result;
        }

        /// <summary>
        /// Возвращает сумму 2 дробных чисел
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        static double Sum(double a, double b)
        {
            double result = a + b;
            return result;
        }

        static void Main(string[] args)
        {
            double result = Sum(2, 3); // метод Sum с 2-мя перегрузками (версиями)
            Console.WriteLine(result);
        }

        /* Иногда возникает необходимость создать один и тот же метод, но с разным набором параметров. 
         * И в зависимости от имеющихся параметров применять определенную версию метода. 
         * Такая возможность еще называется перегрузкой методов (method overloading) */

        /// - описание метода, класса
    }
}
