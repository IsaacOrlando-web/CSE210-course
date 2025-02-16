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
        public void SetIsCompleted(bool completed)
        {
            _isCompleted = completed;
        }
        public SimpleGoal(string name, string description, int points) : base(name, description, points)
        {
        }

        public override void RecordEvent()
        {
            _isCompleted = true;
            base.RecordEvent();
        }

        public override bool IsComplete() //Now the atribute _iscopleted is true, that means that even in the information of the objecte this will be true.
        {
            if(GetIsCompleted() == false)
            {
                return false;
            }else{
                return true;
            }
        }

        public override string GetStringRepresentation()//Ready to save on File .txt
        {
            return $"SimpleGoal,{_shortName},{_description},{_points},{GetIsCompleted()}";
        }
    }
}