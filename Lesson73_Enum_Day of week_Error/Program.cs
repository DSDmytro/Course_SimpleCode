using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson73_Enum_Day_of_week_Error
{
    // Enum
    class Program
    {
        enum DayOfWeek :byte
        {
            Monday = 1,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        static void Main(string[] args)
        {
            DayOfWeek dayOfWeek;
            byte value = 55;
            dayOfWeek = (DayOfWeek) value;
            if (Enum.IsDefined(typeof(DayOfWeek), value))
            {
                dayOfWeek = (DayOfWeek)value; // приводим byte к DayOfWeek
            }
            else
            {
                throw new Exception("Invalid DayOfWeek value.");
            }
            Console.WriteLine(dayOfWeek);
        }
    }
}
