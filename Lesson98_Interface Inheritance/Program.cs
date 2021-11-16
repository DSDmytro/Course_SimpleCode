using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson98_Interface_Inheritance
{
    // Наследование интерфейсов 
    interface IWeapon
    {
        void Fire();
    }
    interface IThrowWeapon : IWeapon
    {
        void Throw();
    }
    class Gun : IWeapon
    {
        public void Fire()
        {
            Console.WriteLine($"{GetType().Name} : Пушка стреляет!");
        }
    }
    class LaserGun : IWeapon
    {
        public void Fire()
        {
            Console.WriteLine($"{GetType().Name} : Лазер стреляет!");
        }
    }
    class Knife : IThrowWeapon
    {
        public void Fire()
        {
            //throw new NotImplementedException();
            Console.WriteLine($"{GetType().Name} : Режу ножом");
        }

        public void Throw()
        {
            //throw new NotImplementedException();
            Console.WriteLine($"{GetType().Name} : Метаю нож");
        }
    }
    class Player
    {
        public void Fire(IWeapon weapon)
        {
            weapon.Fire();
        }
        public void Throw(IThrowWeapon weapon)
        {
            weapon.Throw();
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            IWeapon[] inventory = { new Gun(), new LaserGun(), new Knife() };
            foreach (var item in inventory)
            {
                player.Fire(item);
                Console.WriteLine();
            }
            player.Throw(new Knife());
        }
    }
}
