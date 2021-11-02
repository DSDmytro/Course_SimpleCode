using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson82_Keyword_Static
{
    // Keyword Static 
    class MyClass
    {
        public int a;        // Не статическое поле. Для того, чтобы с ним работать необходимо создавать экземпляр класса

        public static int b; // Статичесое поле. Общее сразу для всех объектов класса. Вызывается сразу классом 

        private static int c;
        public void SetC(int c)
        {
            MyClass.c = c;  // this.c - нельзя использовать
        }
        public void PrintC()
        {
            Console.WriteLine($"C = {c}");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass1 = new MyClass();
            myClass1.a = 44;                   // Для myClass1.a = 44 и myClass2.a = 22 - разная область памяти
            myClass1.SetC(5);

            MyClass myClass2 = new MyClass();  // a - не static, для того, чтобы с ним работать необходимо создавать экземпляр класса
            myClass2.a = 22;
            myClass2.PrintC();

            MyClass.b = 5;                     // Статичесое поле. Общее сразу для всех объектов класса. Вызывается сразу классом 
                                               // Отдельная область памяти
            

        }
    }
}
