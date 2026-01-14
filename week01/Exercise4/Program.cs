using System;
using System.Collections.Generic;

namespace Prep4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating lists
            List<string> names = new List<string>();
            List<int> numbers = new List<int>();
            List<double> prices = new List<double>();
            
            // Adding items to lists
            Console.WriteLine("=== String List Operations ===");
            
            names.Add("Alice");
            names.Add("Bob");
            names.Add("Charlie");
            names.Add("Diana");
            names.Add("Ethan");
            
            Console.WriteLine("Names in the list:");
            foreach (string name in names)
            {
                Console.WriteLine($"- {name}");
            }
            
            // List operations
            Console.WriteLine($"\nTotal names: {names.Count}");
            Console.WriteLine($"First name: {names[0]}");
            Console.WriteLine($"Last name: {names[names.Count - 1]}");
            
            // Remove an item
            names.Remove("Charlie");
            Console.WriteLine("\nAfter removing 'Charlie':");
            foreach (string name in names)
            {
                Console.WriteLine($"- {name}");
            }
            
            // Check if item exists
            Console.Write("\nEnter a name to check: ");
            string searchName = Console.ReadLine();
            
            if (names.Contains(searchName))
            {
                Console.WriteLine($"{searchName} is in the list.");
            }
            else
            {
                Console.WriteLine($"{searchName} is not in the list.");
            }
            
            // Number list operations
            Console.WriteLine("\n=== Number List Operations ===");
            
            // Add numbers from user input
            Console.WriteLine("Enter 5 numbers:");
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Number {i + 1}: ");
                int num = int.Parse(Console.ReadLine());
                numbers.Add(num);
            }
            
            // List statistics
            if (numbers.Count > 0)
            {
                int sum = 0;
                int max = numbers[0];
                int min = numbers[0];
                
                foreach (int num in numbers)
                {
                    sum += num;
                    if (num > max) max = num;
                    if (num < min) min = num;
                }
                
                double average = (double)sum / numbers.Count;
                
                Console.WriteLine($"\nList Statistics:");
                Console.WriteLine($"Sum: {sum}");
                Console.WriteLine($"Average: {average:F2}");
                Console.WriteLine($"Maximum: {max}");
                Console.WriteLine($"Minimum: {min}");
                
                // Sort the list
                numbers.Sort();
                Console.WriteLine("\nSorted numbers:");
                foreach (int num in numbers)
                {
                    Console.Write($"{num} ");
                }
                Console.WriteLine();
                
                // Reverse the list
                numbers.Reverse();
                Console.WriteLine("\nReversed numbers:");
                foreach (int num in numbers)
                {
                    Console.Write($"{num} ");
                }
                Console.WriteLine();
            }
            
            // List of custom objects (simulated with tuples)
            Console.WriteLine("\n=== Shopping Cart Example ===");
            var shoppingCart = new List<(string Item, double Price, int Quantity)>();
            
            shoppingCart.Add(("Apple", 0.99, 5));
            shoppingCart.Add(("Bread", 2.49, 1));
            shoppingCart.Add(("Milk", 3.29, 2));
            shoppingCart.Add(("Eggs", 1.99, 12));
            
            Console.WriteLine("Shopping Cart:");
            double total = 0;
            
            foreach (var item in shoppingCart)
            {
                double itemTotal = item.Price * item.Quantity;
                total += itemTotal;
                Console.WriteLine($"{item.Item} - ${item.Price:F2} × {item.Quantity} = ${itemTotal:F2}");
            }
            
            Console.WriteLine($"\nTotal: ${total:F2}");
        }
    }
}