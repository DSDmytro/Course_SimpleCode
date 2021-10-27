using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson55_Conditional_Null_Operator.NET_Framework
{
    class Program
    {
        //Оператор условного Null    ?.

        static int[] GetArray()
        {
            int[] myArray = null;    // если null вместо    { 1, 2, 3 } - выполняется (myArray?.Sum() ?? 0)
            return myArray;
        }
        static void Main(string[] args)
        {
            int[] myArray = GetArray();
            Console.WriteLine("Сумма элементов массива: " + (myArray?.Sum() ?? 0));
        }
    }
}
