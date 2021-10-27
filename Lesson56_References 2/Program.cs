using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson56_References_2
{
    //Ссылочные локальные переменные
    //Возвращаемые ссылочные значения
    class Program
    {
        static ref int Foo(int[] arr)
        {
            return ref arr[1];//Возвращаемые ссылочные значения
        }

        static void Main(string[] args)
        {
            int[] arr = { 2, 4, 6 };
            ref int b = ref arr[0]; //Ссылочные локальные переменные
            b = -5; //на этом этапе массив выглядит так {-5, 4, 6}
            Console.WriteLine(b);

            ref int c = ref Foo(arr);
            c = 777; //меняются данные и в переменной, и в массиве
            Console.WriteLine(c);

        }
    }
}
