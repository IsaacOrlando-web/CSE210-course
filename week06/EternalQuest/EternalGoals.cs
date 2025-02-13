//Goals that are never complete, but each time the user records them, they gain value.
using System;

namespace EternalQuest
{
    public class EternalGoals : Goal
    {
        // Add properties, methods, and other members here

        public EternalGoals(string name, string description, int value) : base(name, description, value)
        {
            // Constructor logic here
        }

        public override void RecordEvent()
        {
            base.RecordEvent();
        }

        public override bool IsComplete()
        {
            return false;
        }

        public override string GetStringRepresentation()
        {
            return $"EternalGoal: {_shortName}, {_description}, {_points}";
        }
    }
}