using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson24_For
{
    class Program
    {
        static void Main(string[] args)
        {
            //int limit = int.Parse(Console.ReadLine());
            //for (int i = 0; i < limit; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //for (;;)
            //{
            //    Console.WriteLine("For is working");
            //    System.Threading.Thread.Sleep(300);
            //    break;
            //}
            //Console.ReadLine();

            //int i = 0;
            //for (; i < 3; i++)
            //{
            //    Console.WriteLine("For 1: "+i);
            //}
            //for (; i < 5; i++)
            //{
            //    Console.WriteLine("For 2: " + i);
            //}

            //for (int i = 0, j = 5; i < 10 && j < 12; i++, j++)
            //{

            //    Console.WriteLine("i= " + i);
            //    Console.WriteLine("j= " + j);

            //}

            //while (true)
            //{
            //    Console.Clear();
            //    Console.WriteLine("Enter number: ");
            //    for (int i = int.Parse(Console.ReadLine()); i > 0; i--)
            //    {
            //        Console.WriteLine("i= " + i);
            //    }
            //    Console.ReadLine();
            //}

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Enter value I: ");
                int i = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter value J: ");
                int j = int.Parse(Console.ReadLine());

                for (; i < 5; i++, j--)
                {
                    Console.WriteLine("i= " + i);
                    Console.WriteLine("j= " + j);
                }
                Console.ReadLine();
            }


        }
    }
}
