using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7_Method1
{
    /*написать метод, который выводит на екран строку
     *Симовлы из которых состоит строка и их количество задается пользователем 
     */
    class Program
    {
        static void PrintSymbol(string Symbol, int Number)
        {
            for (int i = 0; i < Number; i++)
            {
                Console.Write(Symbol);
            }
            Console.WriteLine();
            for (int j = 1; j <= Number; j++)
            {
                Console.Write(j);
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Console.Write("Enter Symbol: ");
            string Symbol = Console.ReadLine();
            // char Symbol = Console.ReadKey().KeyChar;     - ввод символа с консоли
            Console.Write("Enter number: ");
            int Number = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Result Method");
            PrintSymbol(Symbol, Number);
            Console.WriteLine();

         }
    }
}
