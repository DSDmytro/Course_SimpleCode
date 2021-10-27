using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework9._3_Method_Resize
{
    //Методы для добавление элемента в начало массива, в конец массива и по указанному индексу 
    class Program
    {
        static void Insert(ref int[] myArray, int value, int index)
        {
            int[] newArray = new int[myArray.Length + 1];
            newArray[index] = value;
            for (int i = 0; i < index; i++)
            {
                newArray[i] = myArray[i];
            }
            for (int i = index; i < myArray.Length; i++)
            {
                newArray[i+1] = myArray[i];
            }
            myArray = newArray;
            
        }

        static void AddFirst(ref int[] myArray, int value)
        {
            Insert(ref myArray, value, 0);
        }
        static void AddLast(ref int[] myArray, int value)
        {
            Insert(ref myArray, value, myArray.Length);
        }


        static void Main(string[] args)
        {
            int[] myArray = { 1, 4, 6, 2, 8 };
            AddFirst(ref myArray, -5);
            AddLast(ref myArray, -5);
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }
        }
    }
}
