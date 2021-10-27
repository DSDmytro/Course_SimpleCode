using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework9._1_Method__Resize_
{
    //Метод Resize изменяет количество элементов массива 
    //Метод имеет возможность увеличить или уменьшить количесвто элементов массива 

    class Program
    {
        static void Resize<T>(ref T[] array, int newSize) // <T> - дженерик
        {
            T[] newArray = new T[newSize];
            for (int i = 0; i < array.Length && i < newArray.Length; i++)
            {
                newArray[i] = array[i];
            }
            array = newArray;
        }


        static void Main(string[] args)
        {
            string[] myArray = { "ff", "ddd", "ddd" };
            Resize(ref myArray, 10);

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }
        }
    }
}
