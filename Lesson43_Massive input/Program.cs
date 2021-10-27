using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson43_Massive_input
{
    class Program
    {
        static void Main(string[] args)
        {
            //заполнение массива с помощью Random
            int[,] myArray = new int[10, 6];
            Random random = new Random(); 
            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    myArray[i, j] = random.Next(100);
                }
                
            }

            for (int k = 0; k < myArray.GetLength(0); k++)
            {
                for (int l = 0; l < myArray.GetLength(1); l++)
                {
                    Console.Write(myArray[k,l]+"\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            //заполнение массива с клавиатуры
            int[,] myArray2 = new int[3, 4];
            for (int m = 0; m < myArray2.GetLength(0); m++)
            {
                for (int n = 0; n < myArray2.GetLength(1); n++)
                {
                    Console.Write("Enter index "+ m + " "+ n + ": ");
                    myArray2 [m,n] = int.Parse(Console.ReadLine());
                }
                
            }


            for (int o = 0; o < myArray2.GetLength(0); o++)
            {
                for (int p = 0; p < myArray2.GetLength(1); p++)
                {
                    Console.Write(myArray2[o,p]+"\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
