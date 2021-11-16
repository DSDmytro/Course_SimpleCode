using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson99_Explicit_Interface_Implementation
{
    // Явная реализация интерфейса
    interface IFirstInterface
    {
        void Action();
    }
    interface ISecondInterface
    {
        void Action();
    }
    class MyClass : IFirstInterface, ISecondInterface
    {
        public void Action()
        {
            Console.WriteLine("My Class Action...");
        }
    }
    class MyOtherClass : IFirstInterface, ISecondInterface
    {
        void IFirstInterface.Action() // явная реализация интерфейса. Не может быть public
        {
            Console.WriteLine("My Other Class, First Interfase Action");        
        }
        void ISecondInterface.Action() // явная реализация интерфейса
        {
            Console.WriteLine("My Other Class, Second Interfase Action");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            Foo(myClass);
            Bar(myClass);
            Console.WriteLine();
            MyOtherClass myOtherClass = new MyOtherClass();
            Foo(myOtherClass);
            Bar(myOtherClass);
        }
        static void Foo(IFirstInterface firstInterface)
        {
            firstInterface.Action();
        }
        static void Bar(ISecondInterface secondInterface)
        {
            secondInterface.Action();
        }
    }
}
