using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7._2_Method
{
    /*написать метод для поиска индекса элемента массива
     * метод должен вернуть индекс первого найденного элемента массива (если он будет найден)
     * */

    class Program
    {
        static int FindFunc(int[] myArray, int find) // метод поиска индекса - возвращает индекс, значение которого совпадает со значением, заданным для поиска 
        {
            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] == find)
                {
                    return i;
                }
            }
            return -1; // -1 - значение возвращает, если не находит число в массиве. по аналогии  с методлом inexof
        }

        static int[] GetRandomArray(uint length, int min, int max) //метод заполняет массив случайными числами
        {
            int[] myArray = new int[length];
            Random random = new Random();
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = random.Next(min, max);
            }
            return myArray;

        }

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                int[] myArray = GetRandomArray(10, -5, 20);
                int find = int.Parse(Console.ReadLine());
                int result = FindFunc(myArray, find);
                Console.WriteLine("Result: " + result);
                Console.ReadLine();
            }

        }
    }
}
