using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7_Fill_the_array_from_the_keyboard
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Homework 7: Fill array from the keyboard");
            Console.Write("Enter number: ");
            int x = int.Parse(Console.ReadLine());
            int[] Array = new int [x];
            int count = 0;
            int sum = 0;
            for (int d = 0; d < Array.Length; d++)
            {
                Console.Write($"Enter array value {d}: ");
                Array[d] = int.Parse(Console.ReadLine());
                if (Array[d]%2 == 0)
                {
                    count++;
                    sum += Array[d];
                }

            }
            int min = Array[0];
            for (int z = 0; z < Array.Length; z++)
            {
                if (Array[z] < min)
                {
                    min = Array[z];
                }
            }


            for (int i = 0; i < Array.Length; i++)
            {
                Console.WriteLine("Array Result: "+Array[i]);
            }

            for (int j = Array.Length-1; j >= 0; j--)
            {
                Console.WriteLine("Array Invert: "+Array[j]);
            }
            Console.WriteLine("Amount of evens: "+count);
            Console.WriteLine("Sum of evens: "+sum);
            Console.WriteLine("Min array element: "+min);
            Console.WriteLine("Great Job!");
            Console.ReadLine();

        }
    }
}
