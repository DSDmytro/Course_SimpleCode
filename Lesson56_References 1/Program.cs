using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson56_References_1
{
    // ключеовое слово ref
    class Program
    {
        static void Foo (ref int a) // ref - связывает аргументы. без ref - результат будет а = 2
        {
            a = -5;
        }

        static void Bar(ref int[] arr) //ref - позволяет менять значения
        {
            arr[0] = 2;
            arr[1] = 6;
            arr[2] = 9;
            arr[3] = 10;
        }
        static void Main(string[] args)
        {
            int a = 2; // метод Foo с помощью Ref ссылается на переменную а не копирует в новую переменную. 
            Foo(ref a);
            Console.WriteLine("Varuable: " + a);

            int[] myArray = { 1, 5, 8, 7 };
            Bar(ref myArray); //
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write(myArray[i] + " ");
            }
            
        }
    }
}
