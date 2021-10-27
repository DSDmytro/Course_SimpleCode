using System;

namespace Lesson55_Conditional_Null_Operator
{
    class Program
    {
        //.NET Core - не работает метод Sum ?!
        static int[] GetArray()
        {
            int[] myArray = { 3, 6, 9 };
            return myArray;
        }
        static void Main(string[] args)
        {
            int[] myArray = GetArray();
           // Console.WriteLine("Сумма элементов массива: " + myArray.Sum());    - не работает метод Sum
        }
    }
}
