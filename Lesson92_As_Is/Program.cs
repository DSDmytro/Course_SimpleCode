using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson92_As_Is
{
    // Приведение типов и наследование
    // Использование операторов as, is 
    class Point : Object // В С# все типы неявно унаследованы от типа Object. Имя может быть упрощено 
    {
        public int X { get; set; }
        public int Y { get; set; }

        public void PointXY()
        {
            Console.WriteLine($"X = {X}\nY = {Y}");
        }


    }

    class Program 
    {
        static void Foo(object obj)
        {
            Point point = obj as Point; // Здесь преобразовываем тип object в тип Point. Если типы данных совпадают, то всё ок, если нет, то присвоится null
            // Point point = (Point)obj - если в переменную obj попадет не Point, а другой тип данных, то будет исключение 
            if (point != null)
            {
                point.PointXY();
            }
        }
        static void Bar(object obj)
        {
            if (obj is Point point) // сразу и проверка условия и присваивание obj в point 
            {
                //Point point = (Point)obj; - уже нет необходимости 
                point.PointXY();
            }
        }
        static void Main(string[] args)
        {
            // любой производный тип можно сохранить в ссылке базового класса 
            object obj = new Point {X = 3, Y = 5 }; // операция при которой в ссылку базового класса присваивается объект наследника называется "неявным приведением типа"
            //object obj = "";
            Foo(obj);
            Bar(obj);
            object a = 5; // object может применять любой тип данных
            object b = "String";
            // obj.X obj.Y obj.PrintXY - нет, т.к. базовый класс Object не знает о членах наследника
            Point point = (Point)obj; // явное приведение типов 
            point.PointXY();

        }
    }
}
