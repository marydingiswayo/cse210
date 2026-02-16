using System;

namespace ExerciseTracking
{
    // Base abstract class for all activities
    public abstract class Activity
    {
        // Private member variables (Encapsulation)
        private DateTime _date;
        private int _lengthInMinutes;
        
        // Protected constructor for derived classes
        protected Activity(DateTime date, int lengthInMinutes)
        {
            _date = date;
            _lengthInMinutes = lengthInMinutes;
        }
        
        // Properties with protected getters
        protected DateTime Date => _date;
        protected int LengthInMinutes => _lengthInMinutes;
        
        // Abstract methods (must be implemented by derived classes)
        public abstract double GetDistance(); // in miles or kilometers
        public abstract double GetSpeed();    // in mph or kph
        public abstract double GetPace();     // in minutes per mile or km
        
        // Virtual method that uses polymorphism
        public virtual string GetSummary()
        {
            // Using virtual methods to get specific values
            double distance = GetDistance();
            double speed = GetSpeed();
            double pace = GetPace();
            
            return $"{Date.ToString("dd MMM yyyy")} {GetType().Name} ({LengthInMinutes} min): " +
                   $"Distance: {distance:F1} miles, Speed: {speed:F1} mph, Pace: {pace:F1} min per mile";
        }
    }
}