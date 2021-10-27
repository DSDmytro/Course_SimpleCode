using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson20_Homework4_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                
                Console.WriteLine("CALCULATOR 1");
                double firstValue;
                try
                {
                    Console.Write("Enter 1st number ");
                    firstValue = double.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Error");
                    Console.ReadLine();
                    continue;
                }

                Console.Write("Enter Operator ");
                string oper = Console.ReadLine();
                Console.Write("Enter 2nd number ");
                double secondValue = double.Parse(Console.ReadLine());
                switch (oper)
                {
                    case "+":
                        double add = firstValue + secondValue;
                        Console.WriteLine("Result: " + add);
                        break;
                    case "-":
                        double sub = firstValue - secondValue;
                        Console.WriteLine("Result: " + sub);
                        break;
                    case "*":
                        double mul = firstValue * secondValue;
                        Console.WriteLine("Result: " + mul);
                        break;
                    case "/":
                        if (secondValue != 0)
                        {
                            double dev = firstValue / secondValue;
                            Console.WriteLine("Result: " + dev);
                        }
                        else
                        {
                            Console.WriteLine("Division to 0!!!");
                        }
                        break;
                    default:
                        Console.WriteLine("???");
                        break;
                }
                Console.WriteLine(" ");
                Console.WriteLine("CALCULATOR 2");
                Console.WriteLine("Enter 1st number");
                double firstValue2 = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter Operator");
                string oper2 = Console.ReadLine();
                Console.WriteLine("Enter 2nd number");
                double secondValue2 = double.Parse(Console.ReadLine());
                if (oper2 == "+")
                {
                    double add2 = firstValue2 + secondValue2;
                    Console.WriteLine("Result: " + add2);
                }
                else if (oper2 == "-")
                {
                    double sub2 = firstValue2 - secondValue2;
                    Console.WriteLine("Result: " + sub2);
                }
                else if (oper2 == "*")
                {
                    double mul2 = firstValue2 * secondValue2;
                    Console.WriteLine("Result: " + mul2);
                }
                else if (oper2 == "/")
                {
                    double div2 = firstValue2 / secondValue2;
                    Console.WriteLine("Result: " + div2);
                }
                else
                {
                    Console.WriteLine("???");
                }
                Console.ReadLine();
            }
        }
    }
}
