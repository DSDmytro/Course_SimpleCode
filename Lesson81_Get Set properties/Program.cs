using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson81_Get_Set_properties
{
    // Свойства
    // Get Set 
    class Point
    {
        private int x;

        public void SetX(int x) // Метод, который позволяет установить значение поля - Setter 
        {                       // В данному случае устанавливаем диапозон допустимого вводного значения от 1 до 5
            if (x < 1)          // Таким образом реализована Инкапсуляция
            {                   // В С# есть вместо Get Set спец. инструмент Poperties 
                this.x = 1;
                return;
            }
            if (x > 5)
            {
                this.x = 5;
                return;
            }
        }
        public int GetX() //  Метод, который позволяет получить значение поля - Getter 
        {
            return x;
        }

        // propfull - снипет
        // Свойство Properties 
        private int y;          // напрямую модификатор public не устанавливают, это плохаяч практика

        public int Y
        {
            get { return y; }   // В свойстве Properties ключевые слова Get,Set назівают Accesser 
            set                 // Модификатор аксессора такой же как и у всего свойства - public 
            {
                if (value < 1)
                {
                    y = 1;
                    return;
                }
                if (value > 5)    
                {
                    y = 5;
                    return;
                } 
            }  // Тип данных value точно такой же как и у свойства Y
        }
        public int Z { get; set; }    // Автоматическое свойство - снипет prop


    }

    class Program
    {
        static void Main(string[] args)
        {
            Point point = new Point();
            point.SetX(10); // point.x = 5; - ? почему не сделать переменную Public? - мы бы не смоги поставить условие на диапазон значений х
            int x = point.GetX();
            Console.WriteLine($"x = {x}");

            point.Y = 10;   // В свойство Y присваивается значение 10
        }
    }
}
