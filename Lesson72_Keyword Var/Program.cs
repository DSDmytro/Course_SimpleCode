using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson72_Keyword_Var
{
    // Ключевое слово Var
    // Неявно типизированные локальные переменные

    class Program
    {
        static void Main(string[] args)
        {
            var a = 5;
            Console.WriteLine(a.GetType());
            var b = new float[10];
            Console.WriteLine(b.GetType());
            var c = new { name = "David", age = 25};
            Console.WriteLine(c.GetType());
            var d = new Dictionary<int, string>(); // коллекция, полное написание: Dictionary <int, string> t = new Dictionary<int, string>();
            var e = new List<int>(); // список, полное написание: List<int> f = new List<int>(); 

            // static var Foo(int a);      - не скомпилируется, так как var не используется в типе методов
            // {                            в данному случае используются дженерики 
            // }                            var может использоваться внутри метода 

            // static void Bar(var a);      - не скомпилируется, так как var не используется в параметрах методов
            // {
            // }

            //class myClass                 - не скомпилируется, так как var не используется в полях классов 
            // {
            //public var a; 
            // }

        }
    }
}
