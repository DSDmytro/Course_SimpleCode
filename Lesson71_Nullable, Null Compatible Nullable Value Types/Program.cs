using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson71_Nullable__Null_Compatible_Nullable_Value_Types
{
    class Program
    {
        // Nullable 
        // Null совместимые значимые типы Nullable

        static void Main(string[] args)
        {
            // string str = null;    - нет ошибки
            // int a = null;         - ошибка, int значимый тип и не может хранить null
            // int? a = null;         - нет ошибки, используется ?
            // DateTime Date = null; - ошибка, int значимый тип и не может хранить null

            int? i = null;
            Console.WriteLine(i == null); // True
            Console.WriteLine(i.HasValue); //False
            Console.WriteLine(i.GetValueOrDefault());// 0    нет дефолтного значения
            Console.WriteLine(i.GetValueOrDefault(3));// 3   дефолтное значение 0 
            Console.WriteLine(i ?? 55); //оператор оъїединение null. Если переменная null возвращается значение 55. Наиболее популярный метод
            Console.WriteLine(i.Value); // необработанное исключение






        }




    }
}
