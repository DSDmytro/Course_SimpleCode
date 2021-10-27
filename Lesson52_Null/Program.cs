using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson52_Null
{
    class Program
    {
        class MyClass
        {

        }

        struct MyStruct
        {

        }

        static void Main(string[] args)
        {
            bool b; //по умолчанию хранится "false"
            int a;  //по умолчанию хранится "0"
            double d; //по умолчанию хранится "0"
            Random random; //по умолчанию хранится "Null"
            int[] myArray; //по умолчанию хранится "Null"
            MyClass myClass; //по умолчанию хранится "Null"
            MyStruct myStruct; //по умолчанию хранится "Null"

            // пример разрыва связь между Стеком и Кучей
            int[] Arr;
            Arr = new int[10];
            Arr = null; // в этом месте теряется связь и может происходить утечка памяти (в С++)
            // int Impossible = null; //невозможно присвоить Null значимому типу данных
        }
    }
}
