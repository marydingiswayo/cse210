using System;

namespace Prep1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables declaration
            string firstName;
            string lastName;
            int age;
            double salary;
            
            // Getting user input
            Console.WriteLine("=== User Information ===");
            
            Console.Write("Enter your first name: ");
            firstName = Console.ReadLine();
            
            Console.Write("Enter your last name: ");
            lastName = Console.ReadLine();
            
            Console.Write("Enter your age: ");
            age = int.Parse(Console.ReadLine());
            
            Console.Write("Enter your salary: $");
            salary = double.Parse(Console.ReadLine());
            
            // Displaying output
            Console.WriteLine("\n=== Your Information ===");
            Console.WriteLine($"Full Name: {firstName} {lastName}");
            Console.WriteLine($"Age: {age} years old");
            Console.WriteLine($"Salary: ${salary:F2}");
            
            // Calculations and output
            double monthlySalary = salary / 12;
            double weeklySalary = salary / 52;
            
            Console.WriteLine("\n=== Salary Breakdown ===");
            Console.WriteLine($"Monthly Salary: ${monthlySalary:F2}");
            Console.WriteLine($"Weekly Salary: ${weeklySalary:F2}");
            
            // Display after 5 years
            int futureAge = age + 5;
            double futureSalary = salary * 1.15; // 15% increase
            
            Console.WriteLine("\n=== Future Projection (5 years) ===");
            Console.WriteLine($"Future Age: {futureAge}");
            Console.WriteLine($"Future Salary: ${futureSalary:F2}");
        }
    }
}