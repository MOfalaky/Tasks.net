using System;

namespace MyFirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of small smoles:");
            int CountSmall = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number of Large smoles:");
            int CountLarge = Convert.ToInt32(Console.ReadLine());

            int PriceSmall = 25;
            int PriceLarge = 35;

            int TotalPriceBeforeTax = CountSmall*PriceSmall + CountLarge * PriceLarge;

            double Tax = TotalPriceBeforeTax * .06;

            double TotalPrice = TotalPriceBeforeTax + Tax;

            Console.WriteLine($"the Total Price is {TotalPrice}");


            /*

            */
        }
    }
}
