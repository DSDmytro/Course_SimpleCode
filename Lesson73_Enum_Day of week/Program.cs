using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson73_Enum_Day_of_week
{
    class Program
    {
        enum DayOfWeek :byte // объявление перечисления   :byte - назначение типа данных. По умолчанию будет int   
        {
            Monday = 1,
            Tuesday = 2,
            Wednesday = 3,
            Thursday = 4,
            Friday = 5,
            Saturday = 6,
            Sunday = 7
        }

        static void Main(string[] args)
        {
            DayOfWeek dayOfWeek = DayOfWeek.Tuesday;
            Console.WriteLine(Enum.GetUnderlyingType(typeof(DayOfWeek)));  // получаем тип данных
            Console.WriteLine(dayOfWeek);    // Результат Monday 
            Console.WriteLine((int)dayOfWeek); // Приводим DayOfWeek к Int
            Console.WriteLine((DayOfWeek)3);  // Обратная операция - приводим int к DayOfWeek
            DayOfWeek nextDay = GetNextDay(dayOfWeek);
            Console.WriteLine(nextDay);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="day"></param>
        /// <returns></returns>
        static DayOfWeek GetNextDay(DayOfWeek day)
        {
            if (day < DayOfWeek.Sunday)
            {
                return day + 1;
            }
            return DayOfWeek.Monday;
        }
    }
}
