using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson74_OOP_Class_Example_Student
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

        static void Print(Student student)
        {
            Console.WriteLine($"ID: {student.id}");
            Console.WriteLine($"Last name: {student.lastName}");
            Console.WriteLine($"First name: {student.firstName}");
            Console.WriteLine($"Middle name: {student.middleName}");
            Console.WriteLine($"Age: {student.age}");
            Console.WriteLine($"Group: {student.group}");
        }
        static void Main(string[] args)
        {
            var firstStudent = GetStudent();
            Print(firstStudent);
        }
    }
}
