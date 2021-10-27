using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson45_Three_dimensional_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] myArray = new int[3, 5];//2-мерный массив
            int[,,] myArray2 = new int[4, 3, 5];//3-мерный массив
            myArray2[0, 2, 3] = 55;
            Console.WriteLine(myArray2[0,2,3]);
            Console.WriteLine();

            int[,,] myArray3 = //3-мерный массив
            {
            {{3,5,6},{2,3,1},{5,3,6}},
            {{1,3,2},{8,7,3},{7,6,0}},
            {{6,7,8},{4,3,7},{0,2,5}},
            };
            Console.WriteLine("Rank: " + myArray3.Rank);
            Console.WriteLine("Length: " + myArray3.Length);
            Console.WriteLine();
            Console.WriteLine("My Array 4");

            int[,,] MyArray4 = new int[4, 3, 5]; //3-мерный массив, Random
            Random random = new Random();
            for (int i = 0; i < MyArray4.GetLength(0); i++)
            {
                for (int j = 0; j < MyArray4.GetLength(1); j++)
                {
                    for (int k = 0; k < MyArray4.GetLength(2); k++)
                    {
                        MyArray4[i, j, k] = random.Next(10);
                    }
                }
            }

            for (int i = 0; i < MyArray4.GetLength(0); i++)
            {
                Console.WriteLine("Page # " + (i+1));
                for (int j = 0; j < MyArray4.GetLength(1); j++)
                {
                    for (int k = 0; k < MyArray4.GetLength(2); k++)
                    {
                        Console.Write(MyArray4[i,j,k]+"  ");
                    }
                    Console.WriteLine("\t");
                }
                Console.WriteLine( );
            }

            Console.WriteLine();
            Console.WriteLine("My Array 5");

           
            int[,,,] MyArray5 = new int[3,2,3,5]; //4-мерный массив, Random
            Random random2 = new Random();
            for (int m = 0; m < MyArray5.GetLength(0); m++)
            {
                for (int n = 0; n < MyArray5.GetLength(1); n++)
                {
                    for (int o = 0; o < MyArray5.GetLength(2); o++)
                    {
                        for (int p = 0; p < MyArray5.GetLength(3); p++)
                        {
                            MyArray5[m, n, o, p] = random2.Next(100);
                        }
                    }
                }
            }

            for (int m = 0; m < MyArray5.GetLength(0); m++)
            {
                Console.WriteLine("=== Book # " + (m + 1)+ "===");
                for (int n = 0; n < MyArray5.GetLength(1); n++)
                {
                    Console.WriteLine("Page # " + (n + 1));
                    for (int o = 0; o < MyArray5.GetLength(2); o++)
                    {
                        for (int p = 0; p < MyArray5.GetLength(3); p++)
                        {
                            Console.Write(MyArray5[m, n, o, p] + "\t  ");
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("My Array  6: Stepped Array");
            Console.WriteLine();
            Random random3 = new Random();
            int[][][] MyArray6 = new int[random3.Next(3,6)][][];
            for (int q = 0; q < MyArray6.Length; q++)
            {
                MyArray6 [q]= new int[random3.Next(2,6)][];
                for (int r = 0; r < MyArray6[q].Length; r++)
                {
                    MyArray6[q][r] = new int[random3.Next(2, 6)];

                    for (int s = 0; s < MyArray6[q][r].Length; s++)
                    {
                        MyArray6[q][r][s] = random3.Next(10);
                    }
                }
            }

            for (int q = 0; q < MyArray6.Length; q++)
            {
                Console.WriteLine("Page " + (q+1));
                for (int r = 0; r < MyArray6[q].Length; r++)
                {
                    for (int s = 0; s < MyArray6[q][r].Length; s++)
                    {
                        Console.Write(MyArray6[q][r][s] +" ");   
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }

        }
    }
}
