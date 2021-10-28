using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson73_Enum_Color
{
    class Program
    {
        enum Color
        {
            White,
            Red,
            Green,
            Blue,
            Orange
        }
        static void Main(string[] args)
        {
            var values = Enum.GetValues(typeof(Color));
            foreach (var item in values)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Press any key 0 - 4 or Enter color");
            string str = Console.ReadLine();
            Color color = (Color)Enum.Parse(typeof(Color), str, ignoreCase: true);
            Console.WriteLine(color);

            switch (color)
            {
                case Color.White:
                    break;
                case Color.Red:
                    break;
                case Color.Green:
                    break;
                case Color.Blue:
                    break;
                case Color.Orange:
                    break;
                default:
                    break;
            }
        }
    }
}
