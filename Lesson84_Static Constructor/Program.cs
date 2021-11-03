using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson84_Static_Constructor
{
    //Keyword Static 
    //Статический конструктор 
    class MyClass
    {
        public MyClass()
        {
            Console.WriteLine("Конструктор");
        }
        static MyClass() // В случае со статическими конструкторами модификаторы доступа не используются 

        {
            Console.WriteLine("Статический конструктор");
        }
        public static void Foo()
        {
            Console.WriteLine("Foo");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            new MyClass(); // Создано 3 объекта класса. Не созданы под них переменные, а просто выделена память 
            new MyClass();
            new MyClass();
            MyClass.Foo();
        }
    }
}
