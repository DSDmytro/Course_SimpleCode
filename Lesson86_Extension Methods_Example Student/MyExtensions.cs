using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson86
{
    static class MyExtensions
    {
        public static string GetFullName(this Example_Student student)
        {
            return student.LastName + " " +  student.FirstName;
        }
    }
}
