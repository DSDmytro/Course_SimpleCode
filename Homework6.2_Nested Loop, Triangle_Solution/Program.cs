using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6._2_Nested_Loop__Triangle_Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Homework 6");
            Console.Write("Enter Height: ");
            int height = int.Parse(Console.ReadLine());
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            for (int k = 0; k < height; k++)
            {
                for (int l = height; l > k; l--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            for (int m = 0; m < height; m++)
            {
                for (int p = height - 1; p > m; p--)
                {
                    Console.Write(" ");
                }
                for (int n = 0; n <= m; n++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            for (int q = 0; q < height; q++)
            {
                for (int r = 0; r <= q - 1; r++)
                {
                    Console.Write(" ");
                }
                for (int s = height; s > q; s--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();

            }
            Console.WriteLine();


        }
    }
}
