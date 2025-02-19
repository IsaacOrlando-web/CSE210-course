using System;

namespace ExerciseTracking
{
    public class Swimming : Activity
    {
        private int _laps;

        public Swimming(DateTime date, int durationMinutes,int laps) : base(date, durationMinutes)
        {
            _laps = laps;
        }

        public override double GetDistance()
        {
            return (_laps * 50) / (1000 * 0.62);
        }

        public override double Getpace()
        {
            return _LengthMinutes / GetDistance();
        }

        public override double GetSpeed()
        {
            // Implement the logic to calculate speed
            return 60 / Getpace();
        }

        public override string GetSummary()
        {
            // Implement the logic to get summary
            return $"{_date.ToString("dd MMM yyyy")} Swimming ({_LengthMinutes:F1} min)-Distance {GetDistance():F1} miles, Speed {GetSpeed():F1} mph, Pace: {Getpace():F1} min per mile";
        }
    }
}