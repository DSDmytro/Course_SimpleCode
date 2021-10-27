using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson53_Union_operator_WindowsForms
{
    class Person
    {
    public string FirstName { get; set; }

    public string MiddleName { get; set; }

    public string SecondName { get; set; }

        public string GetFullName()
        {
            return $"Фамилия: {SecondName} Имя: {FirstName} Отчество: {MiddleName ?? "нет данных"}"; 
        }
    }
}
