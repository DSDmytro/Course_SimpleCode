using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson57_Keyword_Out
{
    class Program
    {
        //ключевое слово Out
        //Разница между Ref и Out
        static void Foo(ref int a)
        {
            Console.WriteLine(a);
        }

        static void Bar(out int a)
        {
            a = 5; // The out parameter 'parameter' must be assigned to before control leaves the current method
            Console.WriteLine(a);
        }
        static void Main(string[] args)
        {
            int a = 10;
            Foo(ref a);
            Bar(out a);
            //Bar (out int a)   - краткий способ обїявлениея переменной с методом out, работает только с этим методом
            Console.WriteLine(a);

            //Пример - метод TryParse
            string str = Console.ReadLine();
            int.TryParse(str, out int result);
            Console.WriteLine(result);

        }
    }
}
