using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson42_Massive_output
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] myArray =
            {
                {3,5,8,6,3},
                {45,34,67,78,45},
                {65,34,65,874,34}
            };
            //1ый способ вывода массива
            foreach (int item in myArray)
            {
                Console.Write(item+" ");
            }
            Console.WriteLine(" ");
            Console.WriteLine("Кол-во измерений: " + myArray.Rank); //кол-во измерений массива
            Console.WriteLine("Кол-во 1 измерения: " + myArray.GetLength(0)); //кол-во элементов в 1-ом измерении
            Console.WriteLine("Кол-во 2 измерения: " + myArray.GetLength(1)); //кол-во элементов во 2-ом измерении
            int heigth = myArray.GetLength(0);
            int length = myArray.GetLength(1);
            for (int i = 0; i < heigth; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    Console.Write(myArray[i,j]+"\t");

                }
                Console.WriteLine();
            }

        }
    }
}
