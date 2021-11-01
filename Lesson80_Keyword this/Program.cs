using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson80_Keyword_this
{
    // Keyword this 
    class Student
    {
        public Student(string LastName, DateTime BirthDate)
        {
            
            this.LastName = LastName;
            this.BirthDate = BirthDate;
        }
        public Student(string LastName, string FirstName, string MiddleName, DateTime BirthDate):this(LastName, BirthDate)
        {
            //this.LastName = LastName;   - удалено, так как эта часть вызывается через предыдущий конструктор с помощью this 
            this.FirstName = FirstName;
            this.MiddleName = MiddleName;
            // this.BirthDate = BirthDate; - удалено, так как эта часть вызывается через предыдущий конструктор с помощью this
        }
        public Student(Student student) // Копируем содержимое объекта класса
        {
            this.LastName = student.LastName;
            FirstName = student.FirstName;
            MiddleName = student.MiddleName;
            BirthDate = student.BirthDate;
        }
        public void SetLastName(string LastName)
        {
            this.LastName = LastName;
        }
        private string LastName;
        private string FirstName;
        private string MiddleName;
        private DateTime BirthDate;

        public void Print()
        {
            Console.WriteLine($"Lastname: {LastName} \n Fistname {FirstName} \n Middlename {MiddleName} \n DateOfBirth {BirthDate}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Fren", new DateTime(1988, 10, 5));
            student1.Print();
            
        }
    }
}
