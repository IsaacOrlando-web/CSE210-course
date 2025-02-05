using System;

namespace Homework
{
    public class MathAssignment : Assignment
    {
        // Class properties and methods will go here
        //Attributes
        private string _textbookSection;
        private string _problems;

        //Constructors
        public MathAssignment() : base()
        {
            _textbookSection = "";
            _problems = "";
        }

        public MathAssignment(string name, string topic, string textbooksection, string problems) : base(name, topic)
        {
            _textbookSection = textbooksection;
            _problems = problems;
        }

        //Getters and Setters
        public string GetTextBookSection()
        {
            return _textbookSection;
        }

        public void SetTextBookSection(string BookSection)
        {
            _textbookSection = BookSection;
        }

        public string GetProblems()
        {
            return _problems;
        }

        public void SetProblems(string problems)
        {
            _problems = problems;
        }

        //Methods
        public string GetHomeworkList()
        {

            return $"{GetSummary()} \nSection {GetTextBookSection()} Problems {GetProblems()}";
        }
    }
}