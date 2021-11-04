using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lesson86_Extension_Methods_Code; // добавляем пространство имен для того чтобы использовать написанные расширения методов  

namespace Lesson86_Extension_Methods
{
    //Extension_Methods
    class Program
    {
        static void Main(string[] args)
        {
            DateTime currentDateTime = DateTime.Now;
            Console.WriteLine("Current Date & Time: " + currentDateTime);
            // Задача - создать метод вывода на экран currentDateTime.Print();  то есть новій методя для структуры DateTime
            // так как нельзя изменить структуру DateTime (это часть библиотеки) используем Extension Methods
            currentDateTime.Print(); // реализовано с помощью метода расширения в отдельном классе 
            DateTime.Now.Print(); // работает также, ранее переменная была создана для удобства 
            Console.WriteLine();
            Console.WriteLine(currentDateTime.IsDayOfWeek(DayOfWeek.Friday)); // возвращает true/false если сегодня пятница 
        }
    }
}
