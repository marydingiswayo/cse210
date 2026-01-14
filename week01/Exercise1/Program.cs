using System;
using System.Collections.Generic;

namespace CSharpExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== C# Programming Exercises ===");
            Console.WriteLine("Choose an exercise to run:");
            Console.WriteLine("1. Variables, Input, and Output");
            Console.WriteLine("2. Conditionals");
            Console.WriteLine("3. Loops");
            Console.WriteLine("4. Lists");
            Console.WriteLine("5. Functions");
            Console.WriteLine("6. Exit");
            
            while (true)
            {
                 Console.Write("\nEnter your choice (1-6): ");
                 string choice = Console.ReadLine();
                
                switch (choice)
                {
                    case "1":
                        Exercise1();
                        break;
                    case "2":
                        Exercise2();
                        break;
                    case "3":
                        Exercise3();
                        break;
                    case "4":
                        Exercise4();
                        break;
                    case "5":
                        Exercise5();
                        break;
                    case "6":
                        Console.WriteLine("Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please enter 1-6.");
                        break;
                }
                
                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("=== C# Programming Exercises ===");
                Console.WriteLine("Choose an exercise to run:");
                Console.WriteLine("1. Variables, Input, and Output");
                Console.WriteLine("2. Conditionals");
                Console.WriteLine("3. Loops");
                Console.WriteLine("4. Lists");
                Console.WriteLine("5. Functions");
                Console.WriteLine("6. Exit");
            }
        }
        
        // Exercise 1: Variables, Input, and Output
        static void Exercise1()
        {
            Console.Clear();
            Console.WriteLine("=== Exercise 1: Variables, Input, and Output ===\n");
            
            Console.Write("What is your first name? ");
            string firstName = Console.ReadLine();
            
            Console.Write("What is your last name? ");
            string lastName = Console.ReadLine();
            
            int age;
            while (true)
            {
                Console.Write("What is your age? ");
                if (int.TryParse(Console.ReadLine(), out age) && age > 0)
                    break;
                Console.WriteLine("Please enter a valid positive number.");
            }
            
            Console.Write("What is your favorite color? ");
            string favoriteColor = Console.ReadLine();
            
            Console.WriteLine($"\n=== Results ===");
            Console.WriteLine($"Hello, {firstName} {lastName}!");
            Console.WriteLine($"You are {age} years old and your favorite color is {favoriteColor}.");
            
            int currentYear = DateTime.Now.Year;
            int birthYear = currentYear - age;
            Console.WriteLine($"You were likely born in {birthYear} or {birthYear - 1}.");
        }
        
        // Exercise 2: Conditionals
        static void Exercise2()
        {
            Console.Clear();
            Console.WriteLine("=== Exercise 2: Conditionals ===\n");
            
            Console.Write("Enter the current temperature in Fahrenheit: ");
            
            double temperature;
            while (true)
            {
                string input = Console.ReadLine();
                if (double.TryParse(input, out temperature))
                    break;
                Console.Write("Please enter a valid number: ");
            }
            
            Console.WriteLine("\n=== Weather Recommendation ===");
            
            if (temperature < 32)
            {
                Console.WriteLine("❄️ It's freezing! Wear a heavy coat, gloves, and a hat.");
            }
            else if (temperature < 50)
            {
                Console.WriteLine("🥶 It's cold. Wear a jacket or sweater.");
            }
            else if (temperature < 70)
            {
                Console.WriteLine("😊 It's cool. A light jacket should be sufficient.");
            }
            else if (temperature < 85)
            {
                Console.WriteLine("☀️ It's warm. Short sleeves and pants would be comfortable.");
            }
            else
            {
                Console.WriteLine("🔥 It's hot! Wear light clothing and stay hydrated.");
            }
            
            Console.WriteLine("\n=== Activity Suggestion ===");
            if (temperature > 75)
            {
                Console.WriteLine("Great day for swimming or outdoor sports!");
            }
            else if (temperature > 45)
            {
                Console.WriteLine("Good weather for hiking or a walk in the park.");
            }
            else
            {
                Console.WriteLine("Consider indoor activities or dress very warmly.");
            }
        }
        
        // Exercise 3: Loops
        static void Exercise3()
        {
            Console.Clear();
            Console.WriteLine("=== Exercise 3: Loops ===\n");
            
            Console.WriteLine("1. Countdown with while loop:");
            int count = 5;
            while (count > 0)
            {
                Console.WriteLine($"  {count}...");
                count--;
            }
            Console.WriteLine("  Blast off! 🚀\n");
            
            Console.WriteLine("2. Multiplication table with nested for loops:");
            for (int i = 1; i <= 5; i++)
            {
                Console.Write($"  {i} x table: ");
                for (int j = 1; j <= 5; j++)
                {
                    Console.Write($"{i * j,3}");
                }
                Console.WriteLine();
            }
            
            Console.WriteLine("\n3. Number guessing game (1-10):");
            Random random = new Random();
            int secretNumber = random.Next(1, 11);
            int guess;
            int attempts = 0;
            
            do
            {
                attempts++;
                Console.Write($"  Attempt {attempts}: Guess a number (1-10): ");
                
                while (!int.TryParse(Console.ReadLine(), out guess) || guess < 1 || guess > 10)
                {
                    Console.Write("  Please enter a valid number between 1 and 10: ");
                }
                
                if (guess < secretNumber)
                    Console.WriteLine("    Too low! ↑");
                else if (guess > secretNumber)
                    Console.WriteLine("    Too high! ↓");
                    
            } while (guess != secretNumber);
            
            Console.WriteLine($"  ✅ Correct! You guessed it in {attempts} attempts.");
        }
        
        // Exercise 4: Lists
        static void Exercise4()
        {
            Console.Clear();
            Console.WriteLine("=== Exercise 4: Lists ===\n");
            
            List<string> students = new List<string>
            {
                "Alice Johnson",
                "Bob Smith",
                "Charlie Brown",
                "Diana Prince",
                "Edward Norton"
            };
            
            Console.WriteLine("Initial Student List:");
            for (int i = 0; i < students.Count; i++)
            {
                Console.WriteLine($"  {i + 1}. {students[i]}");
            }
            
            Console.Write("\nEnter a new student name to add: ");
            string newStudent = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(newStudent))
            {
                students.Add(newStudent);
                Console.WriteLine($"Added: {newStudent}");
            }
            
            Console.WriteLine($"\nUpdated Student List ({students.Count} students):");
            foreach (string student in students)
            {
                Console.WriteLine($"  • {student}");
            }
            
            Console.Write("\nEnter a name to remove from the list: ");
            string removeStudent = Console.ReadLine();
            
            if (students.Remove(removeStudent))
            {
                Console.WriteLine($"Removed: {removeStudent}");
            }
            else
            {
                Console.WriteLine($"{removeStudent} not found in the list.");
            }
            
            students.Sort();
            Console.WriteLine("\nFinal Sorted Student List:");
            for (int i = 0; i < students.Count; i++)
            {
                Console.WriteLine($"  {i + 1}. {students[i]}");
            }
        }
        
        // Exercise 5: Functions
        static void Exercise5()
        {
            Console.Clear();
            Console.WriteLine("=== Exercise 5: Functions ===\n");
            
            while (true)
            {
                Console.WriteLine("Choose a function to test:");
                Console.WriteLine("  1. Calculate Factorial");
                Console.WriteLine("  2. Check Prime Number");
                Console.WriteLine("  3. Convert Celsius to Fahrenheit");
                Console.WriteLine("  4. Return to Main Menu");
                Console.Write("Enter choice (1-4): ");
                
                string choice = Console.ReadLine();
                
                switch (choice)
                {
                    case "1":
                        Console.Write("Enter a positive integer: ");
                        if (int.TryParse(Console.ReadLine(), out int n) && n >= 0)
                        {
                            long factorial = CalculateFactorial(n);
                            Console.WriteLine($"Factorial of {n} is {factorial}");
                        }
                        else
                        {
                            Console.WriteLine("Invalid input.");
                        }
                        break;
                        
                    case "2":
                        Console.Write("Enter a number to check: ");
                        if (int.TryParse(Console.ReadLine(), out int num))
                        {
                            bool isPrime = IsPrime(num);
                            Console.WriteLine($"{num} is {(isPrime ? "PRIME ✓" : "NOT PRIME ✗")}");
                        }
                        else
                        {
                            Console.WriteLine("Invalid input.");
                        }
                        break;
                        
                    case "3":
                        Console.Write("Enter temperature in Celsius: ");
                        if (double.TryParse(Console.ReadLine(), out double celsius))
                        {
                            double fahrenheit = CelsiusToFahrenheit(celsius);
                            Console.WriteLine($"{celsius:F1}°C = {fahrenheit:F1}°F");
                        }
                        else
                        {
                            Console.WriteLine("Invalid input.");
                        }
                        break;
                        
                    case "4":
                        return;
                        
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
                
                Console.WriteLine();
            }
        }
        
        // Helper functions for Exercise 5
        static long CalculateFactorial(int n)
        {
            if (n <= 1) return 1;
            long result = 1;
            for (int i = 2; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }
        
        static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;
            
            for (int i = 3; i <= Math.Sqrt(number); i += 2)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }
        
        static double CelsiusToFahrenheit(double celsius)
        {
            return (celsius * 9/5) + 32;
        }
    }
}