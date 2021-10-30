using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection; // подключен namespace 

namespace Lesson76_Access_modifiers_difference_between_public_and_private
{
    class Point
    {
        int z = 7; // Если не объявлять модификатор для члена класса, то по умолчанию будет private
        private int x = 5;
        public int y = 2;

        public void PrintX()
        {
            Console.WriteLine($"X = {x}");
        }

        private void PrintY()
        {
            Console.WriteLine($"Y = {y}");
        }

        public void PrintPoint()
        {
            PrintX();
            PrintY();
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Point point = new Point();
            point.y = 6; // point. - в контекстном меню появляется переменная y. x - не доступно 
            point.PrintX(); // point. - в контекстном меню появляется метод PrintX     PrintY - не доступно
            point.PrintPoint(); // point. - метод доступен

            var typeinfo = typeof(Point).GetFields(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);
            foreach (var item in typeinfo)
            {
                Console.WriteLine($"{item.Name}\t Is Private:{item.IsPrivate}\t Is Public:{item.IsPublic}");
            }


        }
    }
}
