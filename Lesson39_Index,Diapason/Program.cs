using System;

namespace Lesson39_Index_Diapason
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 34, 56, 8, 4, 35, 7, 956, 34, 6, };
            Console.WriteLine(myArray[myArray.Length - 1]); //устаревший способ вывода последнего элемента массива
            Console.WriteLine(myArray[^1]);//новый способ обращения к элементу массива - последний с конца. нумерация с конца начинается с "1"
            int[] Array2 = myArray[1..4];//диапазон (с 56 по 4). последний єлемент не включается в диапазон
            int[] Array3 = myArray[..4];//диапазон с начала массива (с 34 по 4)
            int[] Array4 = myArray[5..];//диапазон с 5 элемента идо конца (с 7 по 6)
            Index myIndex = ^2;//индекс массива (2ой с конца)
            Console.WriteLine("My Index: "+myArray[myIndex]);
            Console.WriteLine($"Value = "+myIndex.Value);
            Console.WriteLine($"Is from end = "+myIndex.IsFromEnd);//булевое значение (отсчет с конца или начала массива)
            Index myIndex2 = new Index(5, true);//индекс массива(5ый с конца)
            Console.WriteLine("My Index 2: " + myArray[myIndex2]);
            Range myRange = 1..4; //диапазон
            int[] Array5 = myArray[myRange];
            Range myRange2 = ^5..^1;//диапазон
            int[] Array6 = myArray[^6..^2];

            string myString = "Hello World! =)";
            Console.WriteLine(myString[3]);
            Console.WriteLine(myString[^9..^2]);
            Console.WriteLine(myString[0..6]);



        }
    }
}
