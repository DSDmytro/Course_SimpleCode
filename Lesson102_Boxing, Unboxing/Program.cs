using System;

namespace Lesson102_Boxing__Unboxing
{
    // Boxing/Unboxing
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;           // int - структура, хранится в стеке 
            object b = a;        // выполняется операция упаковки, object - базовый класс для всех типов данных, размещается в куче
            int c = (int )b;     // оперяция распаковки, выглядит как приведение типов
            // decimal d = (decimal)b;  - ошибка, распаковать можно только в int
            a.GetType(); // Упаовка. а - типа int. GetType метод вызывается у типа Object 
        }
    }
}
