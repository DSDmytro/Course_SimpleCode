using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson88_Const__Readonly
{
    // Keyword Const, Readonly
    class MyClass
    {
        /* Const - в переменную надо сразу присвоить значение
        / Readonly - в переменную значение можно присвоить позже. 
        / Например, если информация поступает из внешних источников
        */
        public const double PI = 3.14; // переменная не меняется
        public const string ERROR = "Some Error";
        public readonly int _a; // можно присвоить на этапе инициализации или в конструкторе
        public static readonly int _b;
        static MyClass()
        {
            _b = 3;
        }

        public MyClass(int a)
        {
            // PI = 3 не скомпилируется, т.к. переменную невозможно изменить
            _a = a;  // можно присвоить на этапе инициализации или в конструкторе
        }

        public void Foo()
        {
            Console.WriteLine(ERROR);
            Console.WriteLine(_a);
            Console.WriteLine(_b);
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass(4);
            myClass.Foo();
        }
    }
}
