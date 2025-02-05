using System;

namespace Homework
{
    public class Assignment
    {
        // Class properties and methods will go here
        protected string _studentName = "";
        protected string _topic = "";

        public string GetStudentName()
        {
            return _studentName;
        }

        public void SetStudentName(string name)
        {
            _studentName = name;
        }

        public string GetTopic()
        {
            return _topic;
        }

        public void SetTopic(string topic)
        {
            _topic = topic;
        }

        public Assignment()
        {
            // Constructor logic will go here
            _studentName = "Anonymous";
            _topic = "Unkown";
        }

        public Assignment(string name, string topic)
        {
            _studentName = name;
            _topic = topic;
        }

        // Additional methods will go here
        public string GetSummary()
        {
            return $"{GetStudentName()} - {GetTopic()}";
        }
    }
}