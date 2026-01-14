using System;

namespace Prep2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Grade calculator with conditionals
            Console.WriteLine("=== Grade Calculator ===");
            
            Console.Write("Enter your score (0-100): ");
            int score = int.Parse(Console.ReadLine());
            
            // Validate input
            if (score < 0 || score > 100)
            {
                Console.WriteLine("Error: Score must be between 0 and 100.");
                return;
            }
            
            string grade;
            string message;
            
            // Determine grade using if-else if
            if (score >= 90)
            {
                grade = "A";
                message = "Excellent!";
            }
            else if (score >= 80)
            {
                grade = "B";
                message = "Good job!";
            }
            else if (score >= 70)
            {
                grade = "C";
                message = "Satisfactory.";
            }
            else if (score >= 60)
            {
                grade = "D";
                message = "Needs improvement.";
            }
            else
            {
                grade = "F";
                message = "Failed. Please try again.";
            }
            
            Console.WriteLine($"\nYour Grade: {grade}");
            Console.WriteLine($"Message: {message}");
            
            // Bonus: Check for + or - grades
            Console.WriteLine("\n=== Detailed Grade ===");
            int lastDigit = score % 10;
            
            if (score >= 60 && score < 100)
            {
                if (lastDigit >= 7 && grade != "A") // A+ not typically used
                {
                    Console.WriteLine($"Detailed Grade: {grade}+");
                }
                else if (lastDigit < 3)
                {
                    Console.WriteLine($"Detailed Grade: {grade}-");
                }
                else
                {
                    Console.WriteLine($"Detailed Grade: {grade}");
                }
            }
            
            // Temperature checker example
            Console.WriteLine("\n=== Temperature Check ===");
            Console.Write("Enter temperature in °C: ");
            double temperature = double.Parse(Console.ReadLine());
            
            if (temperature > 30)
            {
                Console.WriteLine("It's hot outside. Stay hydrated!");
            }
            else if (temperature > 20)
            {
                Console.WriteLine("Nice weather! Perfect for outdoor activities.");
            }
            else if (temperature > 10)
            {
                Console.WriteLine("It's cool. You might need a jacket.");
            }
            else if (temperature > 0)
            {
                Console.WriteLine("It's cold. Wear warm clothes.");
            }
            else
            {
                Console.WriteLine("It's freezing! Stay indoors if possible.");
            }
        }
    }
}