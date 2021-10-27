using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson62._2_Keyword_Params__params_object___parameters_
{
    class Program
    {
        static void Foo(params object [] parameters)
        {
            string message = "Тип данных {0}, значение {1}";
            foreach (var item in parameters)
            {
                Console.WriteLine(message, item.GetType(), item);
            }
        }
        static void Main(string[] args)
        {
            Foo("test", 5, 'q', 6.08f, true);
        }
    }
}
