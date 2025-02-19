//Running class
//Atributes: _distance: double

// Mehotds: 
// GetDistance():double
// 

using System;

namespace ExerciseTracking
{
    public class Cycling : Activity
    {
        private double _speed;

        public Cycling(DateTime date, int durationMinutes,double speed) : base(date, durationMinutes)
        {
            _speed = speed;
        }

        public override double GetDistance()
        {
            return (_speed * _LengthMinutes) / 60;
        }

        public override double Getpace()
        {
            return 60 / _speed;
        }

        public override double GetSpeed()
        {
            // Implement the logic to calculate speed
            return _speed;
        }

        public override string GetSummary()
        {
            // Implement the logic to get summary
            return $"{_date.ToString("dd MMM yyyy")} Cycling ({_LengthMinutes:F1} min)-Distance {GetDistance():F1} miles, Speed {GetSpeed():F1} mph, Pace: {Getpace():F1} min per mile";
        }
    }
}