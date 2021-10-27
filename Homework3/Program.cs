using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            double UsdUah, UsdGbp, UsdAmount;
            UsdUah = 27.23;
            UsdGbp = 02.4;
            Console.WriteLine("Enter USD Amount: ");
            UsdAmount = int.Parse(Console.ReadLine());
            Console.WriteLine(UsdAmount + "USD into UAH = " + UsdAmount*UsdUah);
            Console.WriteLine(UsdAmount + "USD into GBP = " + UsdAmount * UsdGbp);

        }
    }
}
