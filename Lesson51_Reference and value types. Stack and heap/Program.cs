using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson51_Reference_and_value_types.Stack_and_heap
{
    class Program
    {
        static void Foo(int value) //переменная Value мгновенно удаляется из стека, т.к. существует только до тех пор, пока выполняется метод Foo
        {
            value = 1; 
        }
        static void Main(string[] args)
        {
            int a = 5; // структура System.Int32 - "int" - это псевдоним
            Random random = new Random(); // класс
            Foo(a);
            Console.WriteLine(a);// выводитс "5"- т.к. А = 5 - в данном контексте 
        }
    }
}
