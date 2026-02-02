using System;

public class BreathingActivity : Activity
{
    public BreathingActivity() 
        : base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }
    
    public void Run()
    {
        DisplayStartingMessage();
        
        Console.WriteLine("Starting breathing exercise...");
        Console.WriteLine();
        
        StartTimer();
        while (!IsTimeUp())
        {
            Console.Write("Breathe in... ");
            ShowCountdown(4);
            Console.WriteLine();
            
            Console.Write("Now breathe out... ");
            ShowCountdown(6);
            Console.WriteLine();
            Console.WriteLine();
            
            if (IsTimeUp()) break;
        }
        
        DisplayEndingMessage();
    }
}