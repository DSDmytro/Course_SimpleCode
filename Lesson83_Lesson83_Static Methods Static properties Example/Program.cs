using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson83_Lesson83_Static_Methods_Static_properties_Example
{
    class MyClass
    {
        public MyClass() // конструктор
        {
            Counter++;
        }

        private static int counter; // свойство

        public static int Counter
        {
            get { return counter; }
            private set { counter = value; }
        }

        public static int GetCounter()
        {
            return counter;
        }
        public  int GetCounter2()
        {
            return counter;
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass1 = new MyClass();
            MyClass myClass2 = new MyClass();
            Console.WriteLine(myClass1.GetCounter2()); 
            MyClass myClass3 = new MyClass();
            Console.WriteLine(MyClass.Counter);
            Console.WriteLine(MyClass.GetCounter());
        }
    }
}
