using System;
using System.Threading;

public abstract class Activity
{
    // Private member variables (Encapsulation)
    private string _activityName;
    private string _description;
    protected int _duration; // Protected for derived class access
    private DateTime _startTime;
    
    // Constructor
    public Activity(string name, string description)
    {
        _activityName = name;
        _description = description;
    }
    
    // Public methods
    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_activityName} Activity.");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
        
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(3);
    }
    
    public void DisplayEndingMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Well done!");
        ShowSpinner(2);
        Console.WriteLine();
        Console.WriteLine($"You have completed another {_duration} seconds of the {_activityName} Activity.");
        ShowSpinner(3);
    }
    
    // Protected methods for derived classes
    protected void ShowSpinner(int seconds)
    {
        List<string> animationStrings = new List<string> { "|", "/", "-", "\\" };
        int animationIndex = 0;
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        
        while (DateTime.Now < endTime)
        {
            string frame = animationStrings[animationIndex];
            Console.Write(frame);
            Thread.Sleep(200);
            Console.Write("\b \b");
            
            animationIndex = (animationIndex + 1) % animationStrings.Count;
        }
        Console.WriteLine();
    }
    
    protected void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
    
    protected void StartTimer()
    {
        _startTime = DateTime.Now;
    }
    
    protected bool IsTimeUp()
    {
        return DateTime.Now >= _startTime.AddSeconds(_duration);
    }
    
    // Getter for activity name
    public string GetActivityName()
    {
        return _activityName;
    }
}