using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson62_Keyword_Params
{
    // Ключевое слово Params
    class Program
    {
        static int Sum(params int [] parametrs)
        {
            int result = 0;
            for (int i = 0; i < parametrs.Length; i++)
            {
                result += parametrs[i];
            }
            return result;
        }

        static void Main(string[] args)
        {
            int result = Sum(5, 10, 5, 3);
            Console.WriteLine("Result: " + result);
        }


        //static int Sum(int[] parametrs)
        //{
        //    int result = 0;
        //    for (int i = 0; i < parametrs.Length; i++)
        //    {
        //        result += parametrs[i];
        //    }
        //    return result;
        //}

        //static void Main(string[] args)
        //{
        //    int[] myArray = { 1, 3, 6 };
        //    int result = Sum(myArray);
        //    Console.WriteLine("Result: " + result);
        //}


    }
}
