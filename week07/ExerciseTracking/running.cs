using System;

namespace ExerciseTracking
{
    public class Running : Activity
    {
        // Private member variable specific to Running
        private double _distance; // in miles
        
        public Running(DateTime date, int lengthInMinutes, double distance)
            : base(date, lengthInMinutes)
        {
            _distance = distance;
        }
        
        // Override abstract methods
        public override double GetDistance()
        {
            return _distance;
        }
        
        public override double GetSpeed()
        {
            // Speed = (distance / minutes) * 60
            return (_distance / LengthInMinutes) * 60;
        }
        
        public override double GetPace()
        {
            // Pace = minutes / distance
            return LengthInMinutes / _distance;
        }
    }
}