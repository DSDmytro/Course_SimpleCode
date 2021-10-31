using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson77_Encapsulation
{
    // Инкапсуляция
    class Gun
    {
        private bool isLoaded;

        private void Reload()   // Реализация метода скрыта. Так как мы не будем этим управлять самостоятельно в Main 
        {                       // Даем возможность изменить состояние только с помощью методов этого же объекта 
            Console.WriteLine("Заряжаю");
            isLoaded = true;
            Console.WriteLine("Заряжено");
        }
        public void Shoot()
        {
            if (!isLoaded) //(isLoaded != true)
            {
                Console.WriteLine("Оружие не заряжено");
                Reload();
            }
            Console.WriteLine("Стреляю, стреляю ...");
            isLoaded = false;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Gun gun = new Gun();
            // gun.isLoaded = true; - может быть нарушена логика выполнение так как оружие сразу выстрелит 
            gun.Shoot();        
            // метод Reload мы не можем использовать на уровне экземпляра класса 
            // Смысл в том, чтобы перед тем как делать выстрел оружие обязательно было заряжено - без этого нельзя стрелять 
        }
    }
}
