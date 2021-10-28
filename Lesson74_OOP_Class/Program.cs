using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson74_OOP_Class
{
    enum Color
    {
        White,
        Red,
        Green,
        Blue,
    }
    class Point         // создание класса - шаблон, схема экемпляра
    {
        public int x;   // поле класса
        public int y;   // поле класса 
        public Color color; // поле класса 
    }
    class Program
    {
        static void Main(string[] args)
        {
            Point p = new Point();      // создание объекта класса. выделяется место в управляемой куче
            // p = null; // разрывается связь между объектом и упр.кучей 
            p.x = 4;
            p.y = 2;
            p.color = Color.Red;
            Console.WriteLine($"x: {p.x} | y: {p.y} | Color: {p.color}");

            Point p2 = new Point();      // создание объекта класса. выделяется место в управляемой куче
            p2.x = 2;
            p2.y = 6;
            p2.color = Color.Blue;
            Console.WriteLine($"x: {p2.x} | y: {p2.y} | Color: {p2.color}");

        }
    }
}
