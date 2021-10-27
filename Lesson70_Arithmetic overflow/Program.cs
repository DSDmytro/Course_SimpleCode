using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson70_Arithmetic_overflow
{
    class Program
    {
        //"Ядерный Ганди" и арифметическое переполнение
        static void Main(string[] args)
        {
            byte agression = 1;
            byte democracyModifier = 2;
            agression = (byte)(agression - democracyModifier);
            // agression = checked((byte)(agression - democracyModifier)); // checked - возвращает исключение в случае арифметического переполненияя
            Console.WriteLine("Result agression: " + agression);
            Console.WriteLine();

            // Перехват переполнений с помощью конструкции Try Catch
            //try
            //{
            //    agression = checked( (byte)(agression - democracyModifier));
            //    Console.WriteLine("Result agression: " + agression);
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Ошибка переполнения! ");
            //}

            int a = int.MaxValue;
            Console.WriteLine("Максимальное знание Int:            " + a);
            a++;
            Console.WriteLine("Переполнение через верхнюю границу: " + a);

            int b = int.MinValue;
            Console.WriteLine("Минимальное знание Int:             " + b);
            b--;
            Console.WriteLine("Переполнение через нижнюю границу:  " + b);

            ///
            double c = 1.1 / 0.0;
            Console.WriteLine(double.IsInfinity(c)); //true

            double d = 0.0 / 0.0;
            Console.WriteLine(double.IsNaN(d));//true

            double e = double.MaxValue + double.MaxValue;//true
            Console.WriteLine(double.IsInfinity(e));

            decimal f = decimal.MaxValue;
            decimal g = decimal.MaxValue;
            //decimal h = f + g; // Для Decimal всегда будет переполнение и исключение. Этот тип данных нельзя обработать 




        }
    }
}
