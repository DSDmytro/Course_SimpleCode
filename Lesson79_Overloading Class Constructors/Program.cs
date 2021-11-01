using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson79_Overloading_Class_Constructors
{
    // Перегрузка конструкторов класса
    class Point
    {
        public Point()    // конструктор по умолчанию
        {
            _x = _y = 1;
        }
        public Point(int x, int y) // конструктор созданный
        {
            _x = x;
            _y = y;
        }
        private int _x;
        private int _y;

        public void Print()
        {
            Console.WriteLine($"X: {_x} | Y: {_y}");
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Point point = new Point();
            point.Print();
        }
    }
}
