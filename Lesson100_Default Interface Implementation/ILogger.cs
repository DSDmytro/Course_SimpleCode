using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson100_Default_Interface_Implementation
{
    public interface ILogger
    {
        void Log(LogLevel logLevel, string message); // До C#8.0 можно было описывать только сигнатуру методов 

        public void Foo() // Реализация интерфейса по умолчанию
        {
            Console.WriteLine("Пример: реализация интерфейса по умолчанию");
        }
    }
}
