using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson16_If_Else
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isInfected = true;
            if (isInfected)
            {
                Console.WriteLine("The Character is Infected! ");
            }
            else
            {
                Console.WriteLine("The Character is Healty");
            }

            int a = int.Parse(Console.ReadLine());
            if (a == 5)
            {
                Console.WriteLine("a = 5");
            }
            else
            {
                Console.WriteLine("a != 5");
            }
        }
    }
}
