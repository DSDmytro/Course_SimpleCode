using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson41_Massive
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] myArray;
            myArray = new int[3,5];  //долгий способ объявления массива
            int[,] myArray2 = new int[3, 5]; //краткий способ объявлеения массива
            myArray[0, 2] = 99;    //присваивание значения элементу массива
            Console.WriteLine("Result: "+myArray[0,2]);

            int[] myArray3 = { 1, 2, 3, 5, 6 }; //краткий способ присваивания значений в 1-мерном массиве

            int[,] myArray4 = new int[3, 5] //долгий способ присваивания значений 2-мерному массиву
            {
                {3,6,23,6,788},
                {56,34,235,67,5},
                {56,6,8,34,66},
            };

            int[,] myArray5 = //краткий способ присваивания значений 2-мерному массиву
{
                {3,6,23,6,788},
                {56,34,235,67,5},
                {56,6,8,34,66},
};
        }
    }
}
