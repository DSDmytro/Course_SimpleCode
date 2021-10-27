using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework9._4_Method_Resiza
{
    class Program
    {
        //Методы для удаления первого элемента массива, последнего элемента и по индексу 

        static void Delete(ref int [] myArray, int index)
        {
            int[] newArray = new int[myArray.Length-1];
            for (int i = 0; i < index; i++)
            {
                newArray[i] = myArray[i];
            }
            for (int s = index+1; s < newArray.Length; s++)
            {
                newArray[s - 1] = myArray[s];
            }
            myArray = newArray;
        }

        static void DeleteFirst (ref int[] newArray)
        {
            Delete(ref newArray, 0);
        }

        static void DeleteLast(ref int[] newArray)
        {
            Delete(ref newArray, newArray.Length-1);
        }

        static void Main(string[] args)
        {
            int[] myArray = { 1, 3, 5, 7, 9, 11, 13, 15 };
            Delete(ref myArray, 3);
            DeleteFirst(ref myArray);
            DeleteLast(ref myArray);
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }
        }
    }
}
