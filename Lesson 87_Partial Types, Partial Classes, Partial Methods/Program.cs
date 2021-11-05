using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson87_Partial_Types__Partial_Classes__Partial_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Rich", "Gear");
            person.PrintFullName();
        }
    }
}
