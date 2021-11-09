using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson90_Inheritance_Example_Person
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void PrintFullName()
        {
            Console.WriteLine($"First name: {FirstName} \n Last name: {LastName}");
        }
    }
}
