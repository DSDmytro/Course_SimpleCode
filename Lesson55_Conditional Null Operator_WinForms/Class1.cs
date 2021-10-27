using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson55_Conditional_Null_Operator_WinForms
{
    class Person
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string SecondName { get; set; }

        public Contacts Contacts { get; set; }

        public string GetFullName()
        {
            return $"Фамилия: {SecondName} Имя: {FirstName} Отчество: {MiddleName ?? "нет данных"}";
        }
        public string GetPhoneNumber()
        {
            return $"Phone number: {Contacts?.PhoneNumber ?? " нет данных"}";
        }
    }
}
