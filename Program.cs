using System;

namespace TicketPriceCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            const int regularPrice = 10;
            const int discountedPrice = 7;

            Console.Write("Enter your age: ");
            int age = int.Parse(Console.ReadLine());

            int ticketPrice = (age <= 12 || age >= 65) ? discountedPrice : regularPrice;

            Console.WriteLine("Ticket price: GHC" + ticketPrice);
        }
    }
}
