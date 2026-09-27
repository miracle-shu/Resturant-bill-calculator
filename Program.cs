using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resturant_bill_calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("what is total bill amount in pounds");
            decimal bill = decimal.Parse(Console.ReadLine());
            Console.WriteLine("What is the tip percentage");
            decimal tip = int.Parse(Console.ReadLine());
            decimal total_tip = bill * tip / 100;
            decimal total_bill = bill + total_tip;
            Console.WriteLine("how many guests are they");
            int no_guests = int.Parse(Console.ReadLine());
            decimal per_person = total_bill / no_guests;
            Console.WriteLine($"Tip: {total_tip:F2} GBP");
            Console.WriteLine($"Total: {total_bill:F2}  GBP");
            Console.WriteLine($"Per person: {per_person:F2} GBP");






        }
    }
}
