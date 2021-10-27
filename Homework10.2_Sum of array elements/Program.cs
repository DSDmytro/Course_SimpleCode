using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework10._2_Sum_of_array_elements
{
    class Program
    {
        // Sum of array elements
        static int Sum(int[] myArray, int Index = 0)
        {
            //int result = 0;
            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    result = result + myArray[i];
            //}

            if (Index >= myArray.Length)
                return 0;

            int result = Sum(myArray, Index + 1);
            return myArray[Index] + result;
            // return myArray[Index] + Sum(myArray, Index + 1);  - краткий способ
        }
        static void Main(string[] args)
        {
            int[] myArray = { 1, 3, 5, 7, 9 };
            int result = Sum(myArray);
            Console.WriteLine(result);
        }
    }
}
