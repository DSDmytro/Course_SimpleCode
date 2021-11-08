using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson90_Inheritance
{
    // Inheritance Наследование
    class Person            // Person является родительским классом, т.е. базовым классом 
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void PrintName()
        {
            Console.WriteLine($"My name is {FirstName}");
        }
    }
    class Student : Person  // Реализация наследования. Класс Student наследует Person
    {
                            // Student наследует все свойства и методы 
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person { FirstName = "Ivan", LastName = "Drago" };
            person.PrintName();
            Student student = new Student { FirstName = "Keyt", LastName = "Middleton" };
            student.PrintName();
        }
    }
}
