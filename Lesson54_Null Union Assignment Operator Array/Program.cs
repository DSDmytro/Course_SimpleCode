using System;

namespace Lesson54_Null_Union_Assignment_Operator_Array
{
    class Program
    {
        static int[] GetArray()
        {
            int[] myArray = null;
            return myArray;
        }

        static void Main(string[] args)
        {
            int[] myArray = GetArray();
            myArray ??= new int[0];
            Console.WriteLine("Количество элементов в массиве " + myArray.Length);
        }
    }
}
