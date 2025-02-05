using System;

namespace Homework
{
    public class WritingAssignment : Assignment
    {
        // Class properties and methods will go here

        //Atributes: _title(string)
        private string _title;

        //Constructor
        public WritingAssignment() : base()
        {
            _title = "Unknown";
        }
        public WritingAssignment(string name, string topic, string title) : base(name, topic)
        {
            _title = title;
        }

        public string GetWritingInformation()
        {
            return $"{GetSummary()}\n{_title} By {_studentName}";
        }
    }
}