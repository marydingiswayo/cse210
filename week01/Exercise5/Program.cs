using System;

namespace Prep5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Function Demonstrations ===\n");
            
            // Function call examples
            int sum = AddNumbers(10, 20);
            Console.WriteLine($"AddNumbers(10, 20) = {sum}");
            
            double area = CalculateCircleArea(5);
            Console.WriteLine($"Circle area with radius 5 = {area:F2}");
            
            string greeting = CreateGreeting("John");
            Console.WriteLine(greeting);
            
            // Function with no return value
            PrintMultiplicationTable(7);
            
            // Function with array parameter
            int[] numbers = { 3, 7, 2, 9, 5 };
            int maxValue = FindMax(numbers);
            Console.WriteLine($"Maximum value in array = {maxValue}");
            
            // Recursive function
            int factorial = CalculateFactorial(5);
            Console.WriteLine($"Factorial of 5 = {factorial}");
            
            // Function overloading demonstration
            Console.WriteLine($"Add(5, 3) = {Add(5, 3)}");
            Console.WriteLine($"Add(5.5, 3.2) = {Add(5.5, 3.2)}");
            Console.WriteLine($"Add(\"Hello, \", \"World!\") = {Add("Hello, ", "World!")}");
            
            // Using a function with reference parameter
            int x = 10;
            IncrementByOne(ref x);
            Console.WriteLine($"After increment: x = {x}");
            
            // Function with out parameter
            bool isSuccessful = TryDivide(20, 4, out double result);
            if (isSuccessful)
            {
                Console.WriteLine($"20 ÷ 4 = {result}");
            }
        }
        
        // Basic function with parameters and return value
        static int AddNumbers(int a, int b)
        {
            return a + b;
        }
        
        // Function that returns a double
        static double CalculateCircleArea(double radius)
        {
            return Math.PI * radius * radius;
        }
        
        // Function that returns a string
        static string CreateGreeting(string name)
        {
            return $"Hello, {name}! Welcome to the program.";
        }
        
        // Function with no return value (void)
        static void PrintMultiplicationTable(int number)
        {
            Console.WriteLine($"\nMultiplication Table for {number}:");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{number} × {i} = {number * i}");
            }
        }
        
        // Function with array parameter
        static int FindMax(int[] array)
        {
            if (array.Length == 0) return 0;
            
            int max = array[0];
            foreach (int num in array)
            {
                if (num > max) max = num;
            }
            return max;
        }
        
        // Recursive function
        static int CalculateFactorial(int n)
        {
            if (n <= 1) return 1;
            return n * CalculateFactorial(n - 1);
        }
        
        // Function overloading - same name, different parameters
        static int Add(int a, int b)
        {
            return a + b;
        }
        
        static double Add(double a, double b)
        {
            return a + b;
        }
        
        static string Add(string a, string b)
        {
            return a + b;
        }
        
        // Function with reference parameter
        static void IncrementByOne(ref int number)
        {
            number++;
        }
        
        // Function with out parameter
        static bool TryDivide(double dividend, double divisor, out double quotient)
        {
            if (divisor == 0)
            {
                quotient = 0;
                return false;
            }
            
            quotient = dividend / divisor;
            return true;
        }
        
        // Function with default parameter
        static double CalculateTotal(double price, int quantity = 1, double taxRate = 0.08)
        {
            double subtotal = price * quantity;
            double tax = subtotal * taxRate;
            return subtotal + tax;
        }
    }
}