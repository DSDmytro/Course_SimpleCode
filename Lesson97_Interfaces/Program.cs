using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson97_Interfaces
{
    // Интерфейсы и полиморфизм 
    interface IDataProvider // интерфейс предназачен для того, чтобы определить контракт для класса, который получает данные их источника
    {                       
        string GetData(); // метод - как мы хотим получить данные и в каком формате 
        // похоже на абстрактный метод в абстрактном классе - также нет тела метода 
        // в отличии от абстрактных классов в их методах нет модификаторов, т.к. по умолчанию public, веди они должны быть доступны 
    }
    class DbDataProvider : IDataProvider
    {
        public string GetData()
        {
            //throw new NotImplementedException();
            return "Данные из БД";
        }
    }
    class FileDataProvider : IDataProvider
    {
        public string GetData()
        {
            //throw new NotImplementedException();
            return "Данные из файла";

        }
    }
    class APIDataProvider : IDataProvider
    {
        public string GetData()
        {
            //throw new NotImplementedException();
            return "Данные из API";

        }
    }
    interface IDataProcessor // метод для класса, который будет данные обрабатывать 
    { 
        void ProcessData(IDataProvider dataProvider); // метод, который в качестве провайдера принимает объект класса, который будет реализовывать интерфейс IDataProvider
    }
    class ConsoleDataProcessor : IDataProcessor // наследуемся от интерфейса 
    {
        public void ProcessData(IDataProvider dataProvider)
        {
            // throw new NotImplementedException(); - по умолчанию исключение 
            Console.WriteLine(dataProvider.GetData());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            IDataProcessor dataProcessor = new ConsoleDataProcessor();
            dataProcessor.ProcessData(new DbDataProvider());
            dataProcessor.ProcessData(new FileDataProvider());
            dataProcessor.ProcessData(new APIDataProvider());

        }
    }
}
