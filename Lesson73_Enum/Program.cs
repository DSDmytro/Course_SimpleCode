using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson73_Enum
{
    // Enum - перечисления 
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                ConsoleKey key = Console.ReadKey().Key; // Key - Enum
                int keycode = (int)key;
                Console.WriteLine($"\t Enum {key} \t Key Code {keycode}");
                if (key == ConsoleKey.Enter)
                {
                    Console.WriteLine("You Press Enter! ");
                }
            }
        }
    }
}
