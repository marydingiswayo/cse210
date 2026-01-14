using System;

namespace LoopsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== C# LOOPS PRACTICE ===\n");
            
            DemonstrateForLoop();
            DemonstrateWhileLoop();
            DemonstrateDoWhileLoop();
            DemonstrateNestedLoops();
            DemonstrateForeachLoop();
            
            Console.WriteLine("\n=== Program Complete ===");
        }
        
        static void DemonstrateForLoop()
        {
            Console.WriteLine("1. FOR LOOPS");
            Console.WriteLine(new string('-', 40));
            
            // Simple counting
            Console.Write("Counting 1-10: ");
            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
            
            // Counting with step
            Console.Write("Multiples of 3 (0-30): ");
            for (int i = 0; i <= 30; i += 3)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
            
            // Reverse counting
            Console.Write("Countdown from 10: ");
            for (int i = 10; i > 0; i--)
            {
                Console.Write($"{i} ");
                System.Threading.Thread.Sleep(100); // Small delay for effect
            }
            Console.WriteLine("Blastoff!\n");
        }
        
        static void DemonstrateWhileLoop()
        {
            Console.WriteLine("2. WHILE LOOPS");
            Console.WriteLine(new string('-', 40));
            
            // Guess the number game
            Random rand = new Random();
            int secretNumber = rand.Next(1, 51);
            int attempts = 0;
            int guess = 0;
            
            Console.WriteLine("I'm thinking of a number between 1-50...");
            
            while (guess != secretNumber)
            {
                Console.Write("Your guess: ");
                if (!int.TryParse(Console.ReadLine(), out guess))
                {
                    Console.WriteLine("Please enter a valid number.");
                    continue;
                }
                
                attempts++;
                
                if (guess < 1 || guess > 50)
                {
                    Console.WriteLine("Please guess between 1 and 50.");
                }
                else if (guess < secretNumber)
                {
                    Console.WriteLine("Higher!");
                }
                else if (guess > secretNumber)
                {
                    Console.WriteLine("Lower!");
                }
            }
            
            Console.WriteLine($"Correct! You guessed it in {attempts} tries!\n");
        }
        
        static void DemonstrateDoWhileLoop()
        {
            Console.WriteLine("3. DO-WHILE LOOPS");
            Console.WriteLine(new string('-', 40));
            
            char continueChoice;
            
            do
            {
                Console.WriteLine("\n[Math Quiz]");
                
                Random rand = new Random();
                int num1 = rand.Next(1, 11);
                int num2 = rand.Next(1, 11);
                int correctAnswer = num1 * num2;
                int userAnswer;
                
                Console.Write($"What is {num1} × {num2}? ");
                
                while (!int.TryParse(Console.ReadLine(), out userAnswer))
                {
                    Console.Write("Please enter a number: ");
                }
                
                if (userAnswer == correctAnswer)
                {
                    Console.WriteLine("✓ Correct!");
                }
                else
                {
                    Console.WriteLine($"✗ Wrong! The answer is {correctAnswer}");
                }
                
                Console.Write("\nAnother question? (y/n): ");
                continueChoice = Console.ReadKey().KeyChar;
                Console.WriteLine();
                
            } while (continueChoice == 'y' || continueChoice == 'Y');
            
            Console.WriteLine("\nMath quiz ended.\n");
        }
        
        static void DemonstrateNestedLoops()
        {
            Console.WriteLine("4. NESTED LOOPS - PATTERNS");
            Console.WriteLine(new string('-', 40));
            
            // Pyramid pattern
            Console.WriteLine("\nPyramid Pattern:");
            int pyramidHeight = 5;
            
            for (int row = 1; row <= pyramidHeight; row++)
            {
                // Print spaces
                for (int space = 1; space <= pyramidHeight - row; space++)
                {
                    Console.Write(" ");
                }
                
                // Print stars
                for (int star = 1; star <= (2 * row - 1); star++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            
            // Multiplication table
            Console.WriteLine("\nMultiplication Table (1-5):");
            Console.Write("   ");
            for (int header = 1; header <= 5; header++)
            {
                Console.Write($"{header,4}");
            }
            Console.WriteLine("\n   " + new string('-', 20));
            
            for (int i = 1; i <= 5; i++)
            {
                Console.Write($"{i} |");
                for (int j = 1; j <= 5; j++)
                {
                    Console.Write($"{i * j,4}");
                }
                Console.WriteLine();
            }
        }
        
        static void DemonstrateForeachLoop()
        {
            Console.WriteLine("\n5. FOREACH LOOPS");
            Console.WriteLine(new string('-', 40));
            
            // Array of colors
            string[] colors = { "Red", "Orange", "Yellow", "Green", "Blue", "Indigo", "Violet" };
            
            Console.WriteLine("\nColors of the Rainbow:");
            foreach (string color in colors)
            {
                Console.WriteLine($"- {color}");
            }
            
            // Calculate average word length
            int totalLength = 0;
            foreach (string color in colors)
            {
                totalLength += color.Length;
            }
            
            double averageLength = (double)totalLength / colors.Length;
            Console.WriteLine($"\nAverage color name length: {averageLength:F1} letters");
            
            // Filter with foreach (simulated)
            Console.WriteLine("\nShort color names (≤ 5 letters):");
            foreach (string color in colors)
            {
                if (color.Length <= 5)
                {
                    Console.WriteLine($"- {color}");
                }
            }
        }
    }
}