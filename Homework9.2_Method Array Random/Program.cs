using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework9._2_Method_Array_Random
{
    class Program
    {
        static void GetArray()
        {
            Random random = new Random();
            int[] myArray = new int[random.Next(5, 15)];
            for (int j = 0; j < myArray.Length; j++)
            {
                myArray[j] = random.Next(100);
            }
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine($"Index {i}: " + myArray[i]);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Method Array Random");
            GetArray();
        }
    }
}
