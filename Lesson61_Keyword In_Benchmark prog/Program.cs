using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Lesson61_Keyword_In_Benchmark_prog
{
    class Program
    {
        struct Point
        {
            public float x;
            public float y;
            public float z;
        }
        static void Foo(Point value)
        {

        }

        static void Bar(in Point value)
        {

        }

        static void Main(string[] args)
        {
            Point a = new Point();
           

            Stopwatch sw = Stopwatch.StartNew();
            for (int i = 0; i < int.MaxValue; i++)
            {
                Foo(a);
            }
            sw.Stop();
            Console.WriteLine($"Foo {sw.ElapsedMilliseconds}");
            sw.Restart();
            for (int i = 0; i < int.MaxValue; i++)
            {
                Bar(a);
            }
            sw.Stop();
            Console.WriteLine($"Bar {sw.ElapsedMilliseconds}");
        }
    }
}
