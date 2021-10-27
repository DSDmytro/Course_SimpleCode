using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson27_Nested_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine("Loop 1, action: "+i);
                for (int j = 1; j <= 5; j++)
                {
                    Console.WriteLine("\t Loop 2, action: "+j);
                    for (int k = 0; k < 2; k++)
                    {
                        Console.WriteLine("\t\t Loop 3, action: "+k);
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
