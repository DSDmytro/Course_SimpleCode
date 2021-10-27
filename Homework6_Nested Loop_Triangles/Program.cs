using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6_Nested_Loop_Triangles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Homework 6: Nested Loops, Triangles");
            Console.WriteLine("");
            for (int i = 1; i < 4; i++)
            {
                for (int k = 1; k <= 10; k++)
                {
                    for (int j = 1; j <= k; j++)
                    {
                        Console.Write("#");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
                for (int l = 1; l <= 10; l++)
                {
                    for (int m = 10; m > l; m--)
                    {
                        Console.Write("#");
                    }
                    Console.WriteLine("#");
                }
                Console.WriteLine();

                for (int n = 1; n <= 10; n++)
                {
                    for (int o = 1; o < n; o++)
                    {
                        Console.Write("#");
                    }
                    Console.WriteLine("#");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
