using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson90_Inheritance_Example_Person
{
    class Student : Person
    {
        public void Learn()
        {
            Console.WriteLine("Я учусь");
        }
    }
}
