using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson61_Keyword_In
{
    class Program
    {
        // Ключевое слово In
        static void Foo(int value)
        {
            Console.WriteLine(value);
            // a = 10;    В методе есть ключевое слово In - это значит, что мы не можем изменить эту переменную
        }

        static void Main(string[] args)
        {
            int a = 5;
            Foo(a);

        }
    }
}
