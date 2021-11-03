using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson84_Static_Constructor_Example_DbRepository
{
    class DbRepository
    {
        private static string connectionString = "Local DB"; // строка подключения к БД

        static DbRepository()
        {
            ConfigurationManager configurationManager = new ConfigurationManager();
            connectionString = configurationManager.GetConnectionString();
        }

        public void GetData()
        {
            Console.WriteLine("Использую: " + connectionString);
        }
    }
    class ConfigurationManager
    {
        public string GetConnectionString()
        {
            return "Local DB";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            DbRepository dbRepository = new DbRepository();
            dbRepository.GetData();
        }
    }
}
