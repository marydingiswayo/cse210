using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        bool running = true;

        while (running)
        {
            Console.WriteLine("\n=== W01 C# Programming Exercises ===");
            Console.WriteLine("1. Variables, Input, and Output");
            Console.WriteLine("2. Conditionals");
            Console.WriteLine("3. Loops");
            Console.WriteLine("4. Lists");
            Console.WriteLine("5. Functions");
            Console.WriteLine("6. Exit");
            Console.Write("Choose an option (1-6): ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    VariablesExercise();
                    break;
                case "2":
                    ConditionalsExercise();
                    break;
                case "3":
                    LoopsExercise();
                    break;
                case "4":
                    ListsExercise();
                    break;
                case "5":
                    FunctionsExercise();
                    break;
                case "6":
                    running = false;
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
        }
    }

    // 1️⃣ Variables, Input, and Output
    static void VariablesExercise()
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        Console.Write("Enter your age: ");
        int age = int.Parse(Console.ReadLine());

        Console.WriteLine($"Hello {name}, you are {age} years old!");
    }

    // 2️⃣ Conditionals
    static void ConditionalsExercise()
    {
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());

        if (num > 0)
        {
            Console.WriteLine("Positive number");
        }
        else if (num < 0)
        {
            Console.WriteLine("Negative number");
        }
        else
        {
            Console.WriteLine("Zero");
        }
    }

    // 3️⃣ Loops
    static void LoopsExercise()
    {
        Console.WriteLine("Counting from 1 to 5:");
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine(i);
        }
    }

    // 4️⃣ Lists
    static void ListsExercise()
    {
        List<string> fruits = new List<string> { "Apple", "Banana", "Orange" };

        Console.WriteLine("Fruit list:");
        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }

        fruits.Add("Mango");
        Console.WriteLine("After adding Mango:");
        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }
    }

    // 5️⃣ Functions
    static void FunctionsExercise()
    {
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());

        int square = Square(num);
        Console.WriteLine($"The square of {num} is {square}");
    }

    static int Square(int x)
    {
        return x * x;
    }
}
