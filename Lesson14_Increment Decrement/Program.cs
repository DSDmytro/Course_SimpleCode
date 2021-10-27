using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson14_Increment_Decrement
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            a = ++a * a;
            Console.WriteLine(a);
        }
    }
}
