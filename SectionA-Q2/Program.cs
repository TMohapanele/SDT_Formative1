//Question 2
using System;   

namespace SectionA_Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== CTU SIMPLE ATM SYSTEM ===\n");

            Console.WriteLine("HELLO, WHAT IS YOUR NAME? ");
            string name = Console.ReadLine();

            Console.WriteLine($"\nWECLOME {name.ToUpper()}");

            Console.WriteLine("Enter account balance: ");
            double accountBalance = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter withdrawal amount: ");
            double withdrawalAmount = double.Parse(Console.ReadLine());

            double newBalance = accountBalance - withdrawalAmount;
            Console.WriteLine("\nUpdated Amount: " + newBalance);

            Console.WriteLine($"Transaction Time: {DateTime.Now:yyyy-MM-dd HH:mm:ss}");

        }
    }
}