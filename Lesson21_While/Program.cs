using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson21_While
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Lesson 21: While");
                int x = int.Parse(Console.ReadLine());
                int y = 0;
                while (y < x)
                {
                    Console.WriteLine("While");
                    y++;
                }
                Console.ReadLine();
            }
        }
    }
}
