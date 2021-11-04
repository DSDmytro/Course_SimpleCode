using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson85_StaticClass
{
    // Static Class
    // Одно из наиболее частых применений статических классов - это создание методов расширений Extension Methods 
    // Статические классы не наследуются и не используются в реализации интерфейсов, соответственно мы не можем реализовать полиморфизм
    static class MyClass
    {
        static MyClass() // В статических классах используются только статические конструкторы 
        {
            // this.   - не используется, так как по сути это ссылка на объект класс, но в статических классах объекты не создаются 
        }
        public static void Foo()
        {
            Console.WriteLine("Foo");
            //Math.     например, статический класс, который по сути объединяет в себе методы 
        }

        //int a;   - Статический класс может содержать только статические члены: поля, методы, свойства
        // public void Bar() { }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // MyClass myClass = new MyClass();  - невозможно создать объект/экземпляр static класса
            MyClass.Foo(); // метод можно вызвать

            Console.WriteLine(); // Класс Console - пример статического класса. Нет необходимости создавать экземпляр класса, чтобы что-то вывести на экран 
        }
    }
}
