using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson27._2_Nested_Loop_Square
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter heght: ");
            int height = int.Parse(Console.ReadLine());
            Console.Write("Enter width: ");
            int width = int.Parse(Console.ReadLine());

            for (int j = 0; j < height; j++)
            {
                for (int i = 0; i < width; i++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }


            Console.WriteLine();

        }
    }
}
