using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6_Amount_of_Even__Odd_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Homework 5");
                int LimitNumber, StartNumber, Odds, Evens, SumOdds, SumEvens;
                Odds = 0; Evens = 0; SumOdds = 0; SumEvens = 0;
                Console.Write("Enter the Current Number: ");
                StartNumber = int.Parse(Console.ReadLine());
                Console.Write("Enter the Limit Number: ");
                LimitNumber = int.Parse(Console.ReadLine());
                Console.WriteLine(" ");
                Console.WriteLine("Result: ");
                while (StartNumber <= LimitNumber)
                {
                    Console.Write(StartNumber);
                    Console.Write(" ");
                    
                    if (StartNumber % 2 == 0)
                    {
                        Evens++; SumEvens += StartNumber;
                    }
                    else if (StartNumber % 2 != 0)
                    {
                        Odds++; SumOdds += StartNumber;
                    }
                    StartNumber++;
                }
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine("Amount of Evens: " + Evens);
                Console.WriteLine("Amount of Odds: " + Odds);
                Console.WriteLine("Sum of Evens: " + SumEvens);
                Console.WriteLine("Sum of Odds: " + SumOdds);
                Console.WriteLine(" ");
                Console.WriteLine("Great!");
                Console.ReadLine();
            }
        }
    }
}
