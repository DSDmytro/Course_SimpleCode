using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson75_Methods_and_Classes
{
    class Program
    {
        static Student GetStudent()
        {
            Student student = new Student();
            student.lastName = "Shevchenko";
            student.firstName = "Ivan";
            student.middleName = "Sergiyovych";
            student.id = Guid.NewGuid();
            student.age = 17;
            student.group = "3DID";
            return student;
        }

        static void Main(string[] args)
        {
            var firstStudent = GetStudent();
            firstStudent.Print();

            Console.WriteLine();
            Console.WriteLine();

            var secondStudent = new Student();
            secondStudent.firstName = "No name";
            secondStudent.Print();
        }
    }
}
