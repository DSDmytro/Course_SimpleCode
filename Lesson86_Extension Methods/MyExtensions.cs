using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson86_Extension_Methods_Code // павильно будет выделить отдельное пространство имен, чтобы не засорять код для других разработчиков 
{                                         // то есть - дополнительный уровень изоляции 
    static class MyExtensions
    {
        public static void Print(this DateTime datetime) // ключевой момент - какие параметры метод расширения будет принимать 
        {
            Console.WriteLine(datetime);
        }

        public static bool IsDayOfWeek(this DateTime dateTime, DayOfWeek dayOfWeek)
        {
            return dateTime.DayOfWeek == dayOfWeek; 
        }

    }
}
