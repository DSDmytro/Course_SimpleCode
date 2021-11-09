using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson91_Keyword_Base
{
    // Ключевое слово base
    // наследование и конструктор класса 
    class Point2D
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point2D(int x, int y)
        {
            X = x;
            Y = y; 
            Console.WriteLine("Вызван конструктор класса Point2D");
        }

        public void Print2D()
        {
            Console.WriteLine($"X = {X}\nY = {Y}");
        }
    }
    class Point3D : Point2D
    {
        public int Z { get; set; }
        // public Point3D(): base (5, 3)
        public Point3D(int x, int y, int z) : base(x, y) // здесть мы принимаем значения x,y и передаем в базовый класс для их обработки 
        {
            Z = z;
            Console.WriteLine("Вызван конструктор класса Point3D");
        }
        public void Print3D()
        {
            base.Print2D(); // метод-наследник. Ключевое слово base здесь указывать необязательно ведь мы и так можем исопльзовать функционал класса-потомка
            Console.WriteLine($"Z = {Z}");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Point3D point3D = new Point3D(5,3,4);
            point3D.Print3D();
            // нигде явно не создаем объект класса Point2D, тем не менее его конструктор выполнен 
            // т.к. создан объект Point3D, а его базовым классом есть Point2D
            // сначала конструируется предок, базовые классы, затем наследник 
            //
        }
    }
}
