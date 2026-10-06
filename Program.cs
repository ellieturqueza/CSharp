using System;

namespace GradeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nWelcome to the Grade Calculator!\n");

            Console.Write("Enter Your Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Prelim Grade: ");
            double prelimGrade = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Midterm Grade: ");
            double midtermGrade = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Final Grade: ");
            double finalGrade = Convert.ToDouble(Console.ReadLine());

            double averageGrade = (prelimGrade + midtermGrade + finalGrade) / 3;

            Console.WriteLine("\n--- Results ---");
            Console.WriteLine($"Student: {name}");
            Console.WriteLine($"Average\nGrade: {averageGrade}");
            
            if(averageGrade >= 75)
            {
                Console.WriteLine("Status: PASSED\n");
            }
            else
            {
                Console.WriteLine("Status: FAILED\n");
            }
        }
    }
}
