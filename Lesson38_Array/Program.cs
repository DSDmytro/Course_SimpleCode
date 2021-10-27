using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson38_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 111, 10, 6, 5, 6, 111, 7, 3, 66, 77, 332, 54634, 28, 11, 56 };
            int resultMax = myArray.Max();
            Console.WriteLine("Result max: "+ resultMax);
            int resultMin = myArray.Min();
            Console.WriteLine("Result min: " + resultMin);
            int resultSum = myArray.Sum();
            Console.WriteLine("Result sum: "+ resultSum);
            Console.WriteLine("Result sum evens: "+ myArray.Where(i => i%2 == 0).Sum());
            Console.WriteLine("Result min odd: "+ myArray.Where(i => i%2 != 0).Min());
            //исключение повторяющихся элементов массива
            int[] resultUnic = myArray.Distinct().ToArray();
            Console.WriteLine("resultUnic ");
            for (int i = 0; i < resultUnic.Length; i++)
            {
                Console.Write(resultUnic[i]+" ");
            }
            Console.WriteLine();
            //сортировка массива
            Console.WriteLine("Result Orderby");
            int[] resultOrder = myArray.OrderBy(i => i).ToArray();
            for (int j = 0; j < resultUnic.Length; j++)
            {
                Console.Write(resultOrder[j] + " ");
            }
            Console.WriteLine();
            // методы класса Array
            Array.Sort(myArray);              //сортировка
            int Find = Array.Find(myArray, i => i < 70); //поиск єлементов меньше 70. в переменную поместит первый элемент, удовлетворяющий условию
            int[] FindAll = Array.FindAll(myArray, i => i < 40);//поиск элементов меньше 70. в массив поместит все элементы
            int FindIndex = Array.FindIndex(myArray, i => i == 77);//поиск точно по значению
            //int[] Reverse = Array.Reverse(myArray);//элементы массива в обратном порядке
            int[] LINQfindAll = myArray.Where(i => i < 70).ToArray();//поиск всех элментов меньше 70. LINQ
            int LINQfindFirst = myArray.Where(i => i < 70).First();//поиск первого элмента меньше 70. LINQ
            int LINQfinddefault = myArray.Where(i => i < 0).FirstOrDefault(); //если в списке нет такого элемента, то выдает дефолтное значение "0"


        }
    }
}
