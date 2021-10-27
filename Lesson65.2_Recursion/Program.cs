using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson65._2_Recursion
{
    class Program
    {
        class Item
        {
            public int Value { get; set; }
            public Item Child { get; set; }
        }

        static Item InitItem()
        {
            return new Item()
            {
                Value = 5,
                Child = new Item()
                {
                    Value = 10,
                    Child = new Item()
                    {
                        Value = 2
                    }
                }

            };
        }
        static void Print (Item item)
        {
            if (item != null)
            {
                Console.WriteLine(item.Value);
                Print(item.Child);
            }
           
        }


        static void Main(string[] args)
        {
            Item item = InitItem();
            //Print(item);
            for (Item i = item; i != null; i = i.Child)
            {
                Console.WriteLine(i.Value);
            }
        }
    }
}
