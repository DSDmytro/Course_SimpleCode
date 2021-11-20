using System;

namespace Lesson103_Generics
{
    // Generics - обобщения
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1, b = 5;
            Console.WriteLine($"A: {a}\t B: {b}");
            Swap1(ref a, ref b);
            Console.WriteLine($"A: {a}\t B: {b}");
            Swap2(ref a, ref b);
            Console.WriteLine($"A: {a}\t B: {b}");

            Foo<int>(); // Foo метод не прингимает никаких параметров, значит IDE не знает с чем работать и надо явно указать тип в скобках < >
        }
        public static void Swap1(ref int a, ref int b)
        {
            int temp = b;
            b = a;
            a = temp;
        }

        public static void Swap2<T>(ref T a, ref T b) // Generic. Мы не знаем какой тип данных будем использовать
        {                                             // параметры одного типа данных
            T temp = b;
            b = a;
            a = temp;
        }

        static T Foo<T>()
        {
            return default (T);
        }
    }
}
