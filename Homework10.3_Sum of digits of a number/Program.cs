using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework10._3_Sum_of_digits_of_a_number
{
    class Program
    {
        //Сумма всех цифр числа 
        static int Sum(int Value)
        {
            if (Value < 10)
            {
                return Value;
            }

            int digit = Value % 10;
            int nextValue = Value / 10;
            Console.WriteLine("Digit: " + digit);
            Console.WriteLine("Next Value: " + nextValue);
            
            return digit + Sum(nextValue);

        }

        static void Main(string[] args)
        {
            int Value = 123;
            Console.WriteLine("Value: " + Value);
            Console.WriteLine("Sum: " + Sum(Value));

        }
        // Решение с помощью цикла
        //    do
        //    {
        //        int Digit = Value % 10;
        //        Value = Value / 10;
        //        Sumze = Sumze + Digit;
        //    } while (Value > 0);
    }
}
