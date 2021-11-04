using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lesson86
{
    class Program
    {
        static void Main(string[] args)
        {
            Example_Student student = new Example_Student() { FirstName = "Dart", LastName = "Vader" };
            string fullname = student.GetFullName();
            Console.WriteLine("Student: "+ fullname);
        }
    }
}
