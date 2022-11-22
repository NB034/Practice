using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork
{
    internal class Program
    {
        static public void Main()
        {
            Bill bill = new Bill()
            {
                PaymentPerDay = 10,
                DaysWithDelay = 3,
                NumberOfDays = 7,
                PenaltyForOneDayDelay = 2,
            };
            bill.CalculateFields();
            bill.Print();
            bill.Serialize();

            Console.WriteLine();

            Bill bill_2 = bill.Deserialize();
            bill_2.Print();

            Accessories.PressAnyKey();
        }
    }

    internal class Accessories
    {
        static public void PressAnyKey()
        {
            Console.Write("\n[Press any key to continue]");
            Console.ReadKey();
            Console.Clear();
        }
    }

    internal class CustomException : Exception
    {
        public override string Message { get; }
        public CustomException(string message) => Message = message;
    }
}