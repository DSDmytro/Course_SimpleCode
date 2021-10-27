using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework10._1_Outputting_an_array_using_recursion
{
    //Вывод массива с помощью рекурсии
    class Program
    {
        static void Print(int [] myArray, int Index)
        {
            if (Index < myArray.Length)
            {
                Console.WriteLine(myArray[Index]);
                Index++;
                Print(myArray, Index);
            }    
        }

        static void Main(string[] args)
        {

            int[] myArray = { 1, 3, 5, 7, 9, 11, 13, 15};
            Print(myArray, 0);


        }
    }
}
