using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson88_Const__Readonly_Example_Car
{
    class MyLogger
    {
        public void Info(string message)
        {
            Console.WriteLine($"{DateTime.Now}\t|INFO|\t{message}");
        }
        public void Error(string message)
        {
            Console.WriteLine($"{DateTime.Now}\t|ERROR|\t{message}");
        }
        public void Warning(string message)
        {
            Console.WriteLine($"{DateTime.Now}\t|WARN|\t{message}");
        }
    }

    class Car
    {
        private const string ENGINE_IS_STARTED_MESSAGE = "Двигатель запущен!";
        private const string ATTEMPT_TO_START_ENGINE_MESSAGE = "Завожу двигатель";
        private const string ENGINE_HAS_ALREADY_STARTED_MESSAGE = "Двигатель уже запущен";
        private const string ATTEMPT_TO_DRIVE_MESSAGE = "Поехали";
        private const string DRIVE_MESSAGE = "Едем";
        private const string DRIVE_ERROR_MESSAGE = "Сперва заведи двигатель";

        private readonly MyLogger _myLogger;

        private bool isEngineStarted;

        public Car(MyLogger myLogger) // конструктор класса 
        {
            _myLogger = myLogger;
        }

        public void StartEngin()
        {
            _myLogger.Info(ATTEMPT_TO_START_ENGINE_MESSAGE);
            if (isEngineStarted)
            {
                _myLogger.Warning(ENGINE_HAS_ALREADY_STARTED_MESSAGE);
            }
            else
            {
                isEngineStarted = true;
                _myLogger.Info(ENGINE_IS_STARTED_MESSAGE);
            }
        }
        public void Drive()
        {
            _myLogger.Info(ATTEMPT_TO_DRIVE_MESSAGE);
            if (isEngineStarted)
            {
                _myLogger.Info(DRIVE_MESSAGE);
            }
            else
            {
                _myLogger.Error(DRIVE_ERROR_MESSAGE);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(new MyLogger()); // В конструктор объекта Car мы принимаем объект MyLogger, который тут же создаем
            car.Drive();
            car.StartEngin();
            car.StartEngin();
            car.Drive();

        }
    }
}
