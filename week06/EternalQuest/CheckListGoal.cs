using System;

namespace EternalQuest
{
    public class ChecklistGoal : Goal
    {
        // Add properties, methods, and other members here
        private int _amountCompleted; //Track the number of times it has been completed.
        private int _target; //Objetivo, number of times the goal is gonna have

        private int _bonus; 

        //Getters
        public int GetAmount()
        {
            return _amountCompleted;    
        }

        //SetAmount
        public void SetAmount(int number)
        {
            _amountCompleted = number;
        }
        public int GetTarget()
        {
            return _target;    
        }
        public int GetBonus()
        {
            return _bonus;    
        }


        public ChecklistGoal(string name, string description,int value, int target, int bonus) : base(name, description, value)
        {
            // Constructor logic here
            _target = target;
            _bonus = bonus;
        }

        public override void RecordEvent()
        {

            _amountCompleted += 1;
            if(IsComplete() == true)
            {
                SetPoint(_bonus);
            }
            base.RecordEvent();
        }

        public override bool IsComplete()
        {
            if(_amountCompleted == _target)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string GetDetailsString()
        {
            string checklist = "";
            if(IsComplete() == true)
            {
                checklist = "X"; //Mark the checkList with an x if is completed
            }
            else{
                checklist = " ";//Empty if is not completed
            }

            return $"[{checklist}] {_shortName} : {_description} -- Currently completed: {_amountCompleted}/{_target}";
        }
        public override string GetStringRepresentation()
        {
            return $"CheckListGoal,{_shortName},{_description},{_points},{_bonus},{_target},{GetAmount()}";
        }
    }
}