using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson68_Transformation_and_Casting
{
    class Program
    {
        // Преобразование и приведение примитивных типов 
        static void Foo (float value)
        {
            Console.WriteLine(value);
        }
        static void Main(string[] args)
        {
            double a = 5.3;
            float b = (float) a; // явное преобразование   (...)
            Foo((float)a);       // явное преобразование   (...)

            int c = 255;
            byte d = (byte)c;

            int e = 5;
            // bool d = (bool)e;    - приведение в булевый тип не работает. Необходимо вызывать класс Convert 
            bool f = Convert.ToBoolean(e);

            int g = 5;
            float h = 2.5f;
            float result = g + h;

            string i = "5";
            //int j = i;          - из String значения в числовые не переводятся. Необходимо использовать метод Parse
            //int k = (int)i;     - нельзя 
            int j = int.Parse(i);
            int l = Convert.ToInt32(i); 
            
        }
    }
}
