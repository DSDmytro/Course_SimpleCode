using System;

namespace Lesson54_Null_Union_Assignment_Operator_.NET_Core
{
    class Program
    {
        //Оператор присваивания объединения со значением Null
        // .NET 5.0 работает
        // присваивает переменной str заданное значение string.Empty - ""
        static void Main(string[] args)
        {
            string str = null;
            str ??= string.Empty;
            Console.WriteLine("Number of characters in a line: " + str.Length);
        }
    }
}
