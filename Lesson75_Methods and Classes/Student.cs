using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson75_Methods_and_Classes
{
    class Student
    {
        public Guid id;
        public string firstName;
        public string lastName;
        public string middleName;
        public int age;
        public string group;

        public void Print()
        {
            Console.WriteLine("Информация о студенте");
            Console.WriteLine($"ID: {id}");
            Console.WriteLine($"First name: {firstName}");
            Console.WriteLine($"Last name: {lastName}");
            Console.WriteLine($"Middle name: {middleName}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Group: {group}");
        }
    }
}
