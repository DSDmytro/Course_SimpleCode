using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson54_Null_Union_Assignment_Operator
{
    class Program
    {
        //Оператор присваивания объединения со значением Null
        //.NET Framework не работает 
        //присваивает переменной str заданное значение string.Empty - ""
        static void Main(string[] args)
        {
            string str = null;
            // str ??= string.Empty;     - не работает
            Console.WriteLine("Number of characters in a line" + str.Length);
        }
    }
}
