using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson83_Static_Methods_Static_properties
{
    // Статические методы C# | Статические свойства C# 
    class Program
    {
        class MyClass
        {
            private static int a;

            private int b;

            public static void Foo()
            {
                Console.WriteLine("Foo Method");
                // Bar(); - невозможно исользовать, т.к. метод Bar не статический, а значит требует создание экземпляра класса
                // а  для static мметодаFoo экземпляр класса создавать не обязательно 
            }

            public void Bar()
            {
                Console.WriteLine("Bar Method");
                Foo();
            }
        }
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            MyClass.Foo();  // вызов метода на уровне класса
            myClass.Bar();  // вызов метода на уровне экземпляра класса

            Console.WriteLine("Foo Method"); // класс Console метод Writeline - статический метод и это значит, его можно использовать без создания экхемпляра класса 
        }
    }
}
