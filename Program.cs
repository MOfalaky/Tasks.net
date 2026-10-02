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

            Console.WriteLine("Estimate for carpet cleaning service");
            Console.WriteLine($"Number of small carpets:{CountSmall}");
            Console.WriteLine($"Number of Large carpets:{CountLarge}");
            Console.WriteLine($"The Price per small carpet is : {PriceSmall:C}");
            Console.WriteLine($"The Price per large carpet is : {PriceLarge:C}");
            Console.WriteLine($"The Cost is : {TotalPriceBeforeTax:C}");
            Console.WriteLine($"The Tax is : {Tax:C}");
            Console.WriteLine("=========================================");
            Console.WriteLine($"The Total Price is : {TotalPrice:C}");
            Console.WriteLine("This estimate is valid for 30 days");

            // (Standard numeric format) دا حرف يكتب ف الكود يغير شكل الرقم مثلا الي عملة او نسبة مئوية او رقم عشري


        }
    }
}
