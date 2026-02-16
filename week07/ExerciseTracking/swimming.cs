using System;

namespace ExerciseTracking
{
    public class Swimming : Activity
    {
        // Private member variable specific to Swimming
        private int _numberOfLaps;
        
        // Constant for lap length (in meters)
        private const double LapLengthInMeters = 50;
        private const double MetersToMiles = 0.000621371;
        
        public Swimming(DateTime date, int lengthInMinutes, int numberOfLaps)
            : base(date, lengthInMinutes)
        {
            _numberOfLaps = numberOfLaps;
        }
        
        // Override abstract methods
        public override double GetDistance()
        {
            // Convert laps to miles
            double distanceInMeters = _numberOfLaps * LapLengthInMeters;
            return distanceInMeters * MetersToMiles;
        }
        
        public override double GetSpeed()
        {
            // Speed = (distance / minutes) * 60
            double distance = GetDistance();
            return (distance / LengthInMinutes) * 60;
        }
        
        public override double GetPace()
        {
            // Pace = minutes / distance
            double distance = GetDistance();
            return LengthInMinutes / distance;
        }
        
        // Override GetSummary to provide swimming-specific summary
        public override string GetSummary()
        {
            double distance = GetDistance();
            double speed = GetSpeed();
            double pace = GetPace();
            
            return $"{Date.ToString("dd MMM yyyy")} {GetType().Name} ({LengthInMinutes} min): " +
                   $"Distance: {distance:F2} miles, Speed: {speed:F2} mph, Pace: {pace:F2} min per mile, " +
                   $"Laps: {_numberOfLaps}";
        }
    }
}