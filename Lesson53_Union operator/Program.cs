using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson53_Union_operator
{
    // Оператор Null-объединения ??
    class Program
    {
        static void Main(string[] args)
        {
            string str = "test";//
            Console.WriteLine(str);

            string str2 = null;//
            Console.WriteLine(str2);

            string str3 = null;//
            if (str3 == null)
            {
                Console.WriteLine("нет данных");
            }
            else
            {
                Console.WriteLine(str3);
            }

            string str4 = null;// ?? - это оператор Null-объединения
            Console.WriteLine(str4 ?? "нет данных");

            string str5 = "Hello";
            string result = str5 ?? "";
            Console.WriteLine("Symbols in string: " + result.Length);

            string str6 = null;
            string result2 = str6 ?? "";
            Console.WriteLine("Symbols in string: " + result2.Length);
        }
    }
}
