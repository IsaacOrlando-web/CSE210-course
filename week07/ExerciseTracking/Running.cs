//Running class
//Atributes: _distance: double

// Mehotds: 
// GetDistance():double
// 

using System;

namespace ExerciseTracking
{
    public class Running : Activity
    {
        private double _distance;

        public Running(DateTime date, int durationMinutes, double distance) : base(date, durationMinutes)
        {
            _distance = distance;
        }

        public override double GetDistance()
        {
            return _distance;
        }

        public override double Getpace()
        {
            return _LengthMinutes / _distance;
        }

        public override double GetSpeed()
        {
            // Implement the logic to calculate speed
            return _distance / (_LengthMinutes / 60.0);
        }

        public override string GetSummary()
        {
            // Implement the logic to get summary
            return $"{_date.ToString("dd MMM yyyy")} Running ({_LengthMinutes:F1} min)-Distance {GetDistance():F1} miles, Speed {GetSpeed():F1} mph, Pace: {Getpace():F1} min per mile";
        }
    }
}