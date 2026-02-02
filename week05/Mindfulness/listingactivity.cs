using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };
    
    private Random _random = new Random();
    
    public ListingActivity() 
        : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
    }
    
    public void Run()
    {
        DisplayStartingMessage();
        
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine();
        Console.WriteLine($"--- {GetRandomPrompt()} ---");
        Console.Write("You may begin in: ");
        ShowCountdown(5);
        Console.WriteLine();
        
        List<string> items = new List<string>();
        StartTimer();
        
        Console.WriteLine("Start listing:");
        while (!IsTimeUp())
        {
            Console.Write("> ");
            string item = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(item))
            {
                items.Add(item);
            }
        }
        
        Console.WriteLine();
        Console.WriteLine($"You listed {items.Count} items!");
        
        DisplayEndingMessage();
    }
    
    private string GetRandomPrompt()
    {
        return _prompts[_random.Next(_prompts.Count)];
    }
}