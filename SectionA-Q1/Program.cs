//Question 1
using System;

namespace SectionA_Q1
{
    class Program
    {
        static void Main(string[] args) {
            Console.Write("Enter student name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Hello, " + name);

            Console.Write("Enter mark for Subject 1: ");
            int mark1 = int.Parse(Console.ReadLine());

            Console.Write("Enter mark for Subject 2: ");
            int mark2 = int.Parse(Console.ReadLine());

            Console.Write("Enter mark for Subject 3: ");
            int mark3 = int.Parse(Console.ReadLine());

            Console.WriteLine("=== STUDENT RESULTS ===");
        }
    } 
}