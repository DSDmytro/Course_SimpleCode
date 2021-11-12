using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson93_Protected
{
    // Наследование в C# и модификаторы доступа
    // модификатор protected c#
    class A
    {
        public int publicField; // поле
        private int privateField;
        protected int protectedField;
        // private protected int protectedField - также возможно совмещать модификаторы доступа
        // protected - модификатор доступа используется с полями, методами, свойствами
        // private и protected когда мы работаем на уровне одного класса ничем на отличаются, они доступнв внутри класса и не доступны на уровне экземпляров 
        public A()
        {
            Console.WriteLine(publicField); // поле доступно внутри логики самого класса 
            Console.WriteLine(privateField); // поле доступно внутри логики самого класса 
            Console.WriteLine(protectedField); // поле доступно внутри логики самого класса 
        }
        public void Foo()
        {
            Console.WriteLine(publicField); //  
            Console.WriteLine(privateField); //  
            Console.WriteLine(protectedField); // 
        }
    }
    class B: A // класс наследник умеет всё тоже, что и базовый 
    {          // НО только к тому, что имеет доступ
        public B()
        {
            Console.WriteLine(publicField); // имеет доступ всегда и везде 
            // Console.WriteLine(privateField); - нет доступа, т.к. модификатор private 
            // конструктор класса наследник содержит класс базовый, но напрямую доступ к private полю не имеет
            Console.WriteLine(protectedField); // protected доступно при наследовании, в отличии от private
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            Console.WriteLine(a.publicField);
            //Console.WriteLine(a.privateField); - нет доступа из-за уровня защиты 
            // Console.WriteLine(a.protectedField); - нет доступа из-за уровня защиты 
            a.Foo(); // реализация опосредственного доступа к полям private и protected 
        }
    }
}
