using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson33_Array_output
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 3, 5, 8, 9, 3, 6 };
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }
        }
    }
}
