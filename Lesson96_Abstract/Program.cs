using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson96_Abstract
{
    // полиморфизм 
    // абстрактный класс, метод, свойство 
    abstract class Weapon
    {
        public abstract int Damage { get; }
        public abstract void Fire(); // абстрактный класс не содержит тело
                                     // абстрактные методы могут находится только в абстрактных классах 
        public void ShowWeapon()
        {
            Console.WriteLine();
            Console.WriteLine($"{ GetType().Name} Damage: {Damage}");
        }
    }
    class Gun : Weapon
    {
        public override int Damage { get { return 5; } } 

        public override void Fire()
        {
            // throw new NotImplementedException();   - создается по умолчанию
            Console.WriteLine("Пушка!");
        }
    }
    class LaserGun : Weapon
    {
        public override int Damage { get { return 7; } }
        public override void Fire()
        {
            Console.WriteLine("Лазер!");
        }
    }
    class Bow : Weapon
    {
        public override int Damage { get { return 2; } }
        public override void Fire()
        {
            Console.WriteLine("Лук!");
        }
    }
    class Player // всю логику абстрактонго класса можно использовать только в наследниках абстрактного класса 
    {
        public void Fire(Weapon weapon)
        {
            weapon.Fire();           // полиморфизм
        }
        public void CheckInfo(Weapon weapon)
        {
            weapon.ShowWeapon();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            //Gun gun = new Gun();
            //player.Fire(gun);
            Weapon[] inventory = { new Gun(), new LaserGun(), new Bow() };
            foreach (var item in inventory)
            {
                player.CheckInfo(item);
                player.Fire(item);
                Console.WriteLine();
            }
        }
    }
}
