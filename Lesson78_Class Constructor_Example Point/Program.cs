using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson78_Class_Constructor_Example_Point
{
    class Point
    {
        public Point(int x, int y)
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
            Point point = new Point(x: 5, y: 3);
            point.Print();
        }
    }
}
