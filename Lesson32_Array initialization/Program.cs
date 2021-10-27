using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson32_Array_initialization
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray1way = new int[5] {3,4,7,99,4}; // 1 way
            Console.WriteLine(myArray1way[1]);

            int[] myArray2way = new int[] { 2, 5, 7 }; //2 way
            Console.WriteLine(myArray2way[1]);

            int[] myArray3way = { 4, 2, 3, 7, 8 }; //3 way
            Console.WriteLine(myArray3way[3]);

            int[] myArray4 = Enumerable.Repeat(4, 5).ToArray(); //5 элементов, все 4

            int[] myArray5 = Enumerable.Range(6, 9).ToArray(); //9 элементов, начиная с 6

            Console.ReadLine();
        }
    }
}
