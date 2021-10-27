using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Lesson65_Recursion
{
    //Рекрсия. Методы и стек. Стек переполнен
    class Program
    {
        static void Foo(int i)
        {
            Console.WriteLine(i);
        //    Thread.Sleep(100);

         //   if (i >= 5)
         //       return;
            
            i++;
            Foo(i);

        }
        static void Main(string[] args)
        {
            Foo(1);

        }



        //static void Foo()
        //{
        //    Console.WriteLine("Foo");
        //    Thread.Sleep(50);
        //    Foo();

        //}
        //static void Main(string[] args)
        //{
        //    Foo();

        //}
    }
}
