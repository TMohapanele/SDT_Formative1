//Question 1
using System;

namespace SectionA_Q1
{
    class Program
    {
        static void Main(string[] args) {
            Console.Write("Enter student name: ");
            string name = Console.ReadLine();

            Console.WriteLine("\nHello, " + name);

            Console.Write("Enter mark for Subject 1: ");
            int mark1 = int.Parse(Console.ReadLine());

            Console.Write("Enter mark for Subject 2: ");
            int mark2 = int.Parse(Console.ReadLine());

            Console.Write("Enter mark for Subject 3: ");
            int mark3 = int.Parse(Console.ReadLine());

            Console.WriteLine("\n=== STUDENT RESULTS ===");

            //Output
            Console.WriteLine("Student Name: " + name);

            int totalMarks = mark1 + mark2 + mark3;
            Console.WriteLine("Total Marks: " + totalMarks);

            double aveMarks = totalMarks / 3.0;
            Console.WriteLine($"Average Marks: {aveMarks:F2}"); //F2 means 2 decimal places

            // Determine pass or fail based on average marks
            bool isPassed = aveMarks >= 50;
            Console.WriteLine("Pass Status: " + (isPassed ? "Passed" : "Failed"));  //condition? true:false

        }
    } 
}