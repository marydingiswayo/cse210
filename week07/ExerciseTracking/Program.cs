using System;
using System.Collections.Generic;

namespace ExerciseTracking
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercise Tracking Program");
            Console.WriteLine("=========================\n");
            
            // Create a list to hold all activities (Polymorphism in action)
            List<Activity> activities = new List<Activity>();
            
            // Create different types of activities
            Activity running1 = new Running(new DateTime(2024, 11, 3), 30, 3.0);
            Activity running2 = new Running(new DateTime(2024, 11, 5), 45, 4.5);
            Activity cycling1 = new Cycling(new DateTime(2024, 11, 4), 60, 15.0);
            Activity cycling2 = new Cycling(new DateTime(2024, 11, 6), 90, 20.0);
            Activity swimming1 = new Swimming(new DateTime(2024, 11, 3), 30, 40);
            Activity swimming2 = new Swimming(new DateTime(2024, 11, 7), 45, 60);
            
            // Add all activities to the same list (Polymorphism)
            activities.Add(running1);
            activities.Add(running2);
            activities.Add(cycling1);
            activities.Add(cycling2);
            activities.Add(swimming1);
            activities.Add(swimming2);
            
            // Display summaries for all activities
            Console.WriteLine("Activity Summaries:");
            Console.WriteLine("-------------------");
            
            foreach (Activity activity in activities)
            {
                // Polymorphism: Calling GetSummary() on Activity, but gets the appropriate implementation
                Console.WriteLine(activity.GetSummary());
                Console.WriteLine();
            }
            
            // Additional demonstration of polymorphism
            Console.WriteLine("\nDemonstrating Polymorphism:");
            Console.WriteLine("---------------------------");
            
            // Even though they're stored as Activity, they retain their specific type behavior
            Console.WriteLine($"Running Distance: {running1.GetDistance():F2} miles");
            Console.WriteLine($"Cycling Speed: {cycling1.GetSpeed():F2} mph");
            Console.WriteLine($"Swimming Pace: {swimming1.GetPace():F2} min per mile");
            
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}