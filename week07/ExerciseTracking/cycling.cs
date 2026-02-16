using System;

namespace ExerciseTracking
{
    public class Cycling : Activity
    {
        // Private member variable specific to Cycling
        private double _speed; // in mph
        
        public Cycling(DateTime date, int lengthInMinutes, double speed)
            : base(date, lengthInMinutes)
        {
            _speed = speed;
        }
        
        // Override abstract methods
        public override double GetDistance()
        {
            // Distance = speed * (minutes / 60)
            return _speed * (LengthInMinutes / 60.0);
        }
        
        public override double GetSpeed()
        {
            return _speed;
        }
        
        public override double GetPace()
        {
            // Pace = 60 / speed (minutes per mile)
            return 60 / _speed;
        }
    }
}