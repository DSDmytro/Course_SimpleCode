using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson100_Default_Interface_Implementation
{
    public static class Extensions
    {
        public static void Foo(this ILogger logger)
        {
            Console.WriteLine("Пример: расширение");
        }


    }
}
