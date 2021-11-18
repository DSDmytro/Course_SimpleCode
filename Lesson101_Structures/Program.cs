using System;

namespace Lesson101_Structures
{
    class ClassPoint
    {
        public int X { get; set; }
        public int Y { get; set; }

        public void Point()
        {
            Console.WriteLine($"X: {X}\t Y: {Y}");
        }
    }
    struct StructPoint
    {
        public int X { get; set; }
        public int Y { get; set; }

        public void Point()
        {
            Console.WriteLine($"X: {X}\t Y: {Y}");
        }
    }
    class Program
    {
        public static void Foo(ClassPoint classPoint) // метод получает доступ по ссылке 
        {                                             //соответственно, если данные меняются в методе, они реально меняются
            classPoint.X++;
            classPoint.Y++;
        }
        public static void Bar(StructPoint structPoint) // метод получает доступ по значеению
        {                                               // данные менются только в методе
            structPoint.X++;
            structPoint.Y++;
        }

        static void Main(string[] args)
        {
            ClassPoint classPoint = new ClassPoint();
            classPoint.X = 5;
            classPoint.Y = 3;
            classPoint.Point();

            StructPoint structPoint = new StructPoint();
            structPoint.X = 8;
            structPoint.Y = 6;
            structPoint.Point();
            Console.WriteLine();

            Foo(classPoint); // данные передаются по ссылке
            Bar(structPoint); // данные передаются по значению
            classPoint.Point(); 
            structPoint.Point();

            ClassPoint classPoint2 = new ClassPoint();
            classPoint2.X = 1;
            classPoint2.Y = 2;
            ClassPoint classPoint3 = new ClassPoint();
            classPoint3.X = 1;
            classPoint3.Y = 2;

            StructPoint structPoint2 = new StructPoint();
            structPoint2.X = 1;
            structPoint2.Y = 2;
            StructPoint structPoint3 = new StructPoint();
            structPoint3.X = 1;
            structPoint3.Y = 2;

            bool classEqul = classPoint2.Equals(classPoint3);     // сравнение происходит по ссылкам
            Console.WriteLine($"Class Equal: {classEqul}");       // False 
            bool structEqual = structPoint2.Equals(structPoint3); // сравнение происходит по значениям
            Console.WriteLine($"Struct Equal: {structEqual}");    // True
        }
    }
}
