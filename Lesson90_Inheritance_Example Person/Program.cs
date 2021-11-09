using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson90_Inheritance_Example_Person
{
    class Program
    {
        static void Main(string[] args)
        {
            Teacher teacher = new Teacher { FirstName = "Stephen", LastName = "King" };
            Student student = new Student { FirstName = "Oan", LastName = "Coal" };
            Person[] people = { teacher, student };

            PrintPersons(people);
        }

        static void PrintPersons(Person[] people)
        {
            foreach (var person in people)
            {
                person.PrintFullName();
            }
        }
    }
}
