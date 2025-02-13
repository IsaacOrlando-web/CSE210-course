namespace EternalQuest
{
    public class SimpleGoal : Goal
    {
        // Add properties, methods, and constructors here
        private bool _isCompleted = false;//False by default

        //Get the bool attibute
        public bool GetIsCompleted()
        {
            return _isCompleted;
        }
        public SimpleGoal(string name, string description, int points) : base(name, description, points)
        {
        }

        public override void RecordEvent()
        {
            Console.WriteLine("Congrats!!! You made a good job");
            base.RecordEvent();
        }

        public override bool IsComplete() //Now the atribute _iscopleted is true, that means that even in the information of the objecte this will be true.
        {
            _isCompleted = true;
            return _isCompleted;
        }

        public override string GetStringRepresentation()//Ready to save on File .txt
        {
            return $"Simple Goal: {_description}, {_points}, {_isCompleted}";
        }
    }
}