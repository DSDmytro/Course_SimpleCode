using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson79_Overloading_Class_Constructors_Example_Student
{
    class Student
    {
        public Student(string LastName, DateTime BirthDate)
        {
            _LastName = LastName;
            _BirthDate = BirthDate;
        }
        public Student(string LastName, string FirstName, string MiddleName, DateTime BirthDate)
        {
            _LastName = LastName;
            _FirstName = FirstName;
            _MiddleName = MiddleName;
            _BirthDate = BirthDate;
        }
        public Student(Student student) // Копируем содержимое объекта класса
        {
            _LastName = student._LastName;
            _FirstName = student._FirstName;
            _MiddleName = student._MiddleName;
            _BirthDate = student._BirthDate;
        }
        public void SetLastName(string LastName)
        {
            _LastName = LastName; 
        }
        private string _LastName;
        private string _FirstName;
        private string _MiddleName;
        private DateTime _BirthDate;

        public void Print()
        {
            Console.WriteLine($"Lastname: {_LastName} \n Fistname {_FirstName} \n Middlename {_MiddleName} \n DateOfBirth {_BirthDate}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Fren", new DateTime(1988, 10, 5));
            Student student2 = student1; // Присваивается - не копируется
            Student student3 = new Student(student1); // Создается новый объект
            student1.SetLastName("Derak");
            student1.Print();
            Console.WriteLine();
            student2.Print();
            Console.WriteLine();
            student3.Print();
        }
    }
}
