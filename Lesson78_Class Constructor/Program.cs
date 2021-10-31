using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson78_Class_Constructor
{
    // Конструктор класса. Конструктор по умолчанию
    class Gun
    {
        public Gun(bool isLoaded)    // Конструктор класса. В скобках принимаемые параметры, не обязательно
        {

            _isLoaded = isLoaded;
            //this.isLoaded = isLoaded;
            //Reload();
            // isLoaded = true;
        }

        private bool _isLoaded;

        private void Reload()
        { 
            Console.WriteLine("Заряжаю");
            _isLoaded = true;
            Console.WriteLine("Заряжено");
        }
        public void Shoot()
        {
            if (!_isLoaded) 
            {
                Console.WriteLine("Оружие не заряжено");
                Reload();
            }
            Console.WriteLine("Стреляю, стреляю ...");
            _isLoaded = false;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Gun gun = new Gun(false);   // Gun() - конструктор класса по умолчанию. Реализовано так, что
                                        // мы имеем возможность создавать пушку в 2 вариантах, заряженую либо разряженую изначально
            gun.Shoot();
            //gun.Shoot();

        }
    }
}
