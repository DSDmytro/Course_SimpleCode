using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson31_Ternary_Operator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Part 1");
            Console.Write("Enter Password: ");
            bool AccessAllowed;
            string SavedPass = "qwerty";
            string EnteredPass = Console.ReadLine();

            //if (EnteredPass == SavedPass)
            //{
            //    AccessAllowed = true;
            //}
            //else
            //{
            //    AccessAllowed = false;
            //}
            //Console.WriteLine("Password: "+AccessAllowed);

            AccessAllowed = EnteredPass == SavedPass ? true : false;
            Console.WriteLine("Password: "+AccessAllowed);
            Console.ReadLine();

            Console.WriteLine("Part 2");
            Console.WriteLine("If number < 0 then number = 0");
            Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine());
            number = number > 0 ? number : 0;
            Console.WriteLine("Number: "+number);
        }
    }
}
