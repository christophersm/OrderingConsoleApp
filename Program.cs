using System;

namespace BatteriesUnlimited
{
    class Program
    {
        static string AskQuestion(string question)
        {
            Console.Write(question + " ");
            return Console.ReadLine();
        }

        //Quantity times price
        static double Price(int quantity)
        {
            double pricePerUnit;

            if (quantity >= 10)
            {
                pricePerUnit = 48.0;
            }
            else if (quantity >= 5)
            {
                pricePerUnit = 50.0;
            }
            else
            {
                pricePerUnit = 52;
            }
            return quantity * pricePerUnit;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Camera Battery Store");
            string entry = AskQuestion("How many batteries are you ordering?");
            int number = int.Parse(entry);
            double total = Price(number);

            Console.WriteLine($"For {number} batteries, your total is: ${total}");
        }
    }
}
