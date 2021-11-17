using System;

namespace Lesson100_Default_Interface_Implementation
{
    // Реализация интерфейса по умолчанию в C# 8.0
    class Program
    {
        static void Main(string[] args)
        {
            ILogger consoleLogger = new ConsoleLogger();
            consoleLogger.Foo();
            consoleLogger.Log(LogLevel.Debug, "some event");
            consoleLogger.Log(LogLevel.Warning, "some warning");
            consoleLogger.Log(LogLevel.Fatal, "some fatal error");

        }
    }
}
