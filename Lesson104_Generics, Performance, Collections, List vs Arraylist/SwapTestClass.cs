using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson104_Generics__Performance__Collections__List_vs_Arraylist
{
    public static class SwapTestClass
    {
        // Два метоода реализуют одну и туже логику. 
        // Обобщения сразу определяют входящий тип данных, что позволяет не передавать данные в кучу и не работает сборщик мусора
        // Метод с типом object переводят данные в кучу
        public static void GenericSwap<T>(ref T a, ref T b)
        {
            T temp = b;
            a = b;
            b = temp;
        }
        public static void ObjectSwap(ref object a, ref object b)
        {
            object temp = b;
            a = b;
            b = temp;
        }
    }
}
