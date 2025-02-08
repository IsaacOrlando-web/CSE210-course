using System;
using System.Collections.Generic;
using System.Threading;

namespace Mindfulness
{
    public class ReflectingActivity : Activity
    {
        private List<string> _prompts;
        private List<string> _questions;
        
        //Constructor
        public ReflectingActivity() : base()
        {
            _name = "Reflection Activity";
            _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";

            _prompts = ["Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless."];
            _questions = ["Why was this experience meaningful to you?","Have you ever done anything like this before?", "How did you get started?", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?", "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?", "What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future?"];
        }

        public string GetRandomPrompt()
        {
            Random random = new Random();
            string randomprompt = _prompts[random.Next(_prompts.Count)];

            return randomprompt;
        }

        public string GetRandomQuestion()
        {
            Random random = new Random();
            string randomprompt = _questions[random.Next(_questions.Count)];

            return randomprompt;
        }

        public void DisplayPrompt()
        {
            Console.Write(">" + GetRandomPrompt());
            ShowSpinner();
        }

        public void DisplayQuestions()
        {
            Console.Write(">" + GetRandomQuestion());
            ShowSpinner();
        }

        public void Run()//Put the timer Here
        {
            Console.Clear();
            DisplayStartingMessage();
            Console.Clear();

            DateTime startTime = DateTime.Now;
            DateTime futureTime = startTime.AddSeconds(_duration);
            
            DateTime currentTime = DateTime.Now;
            while(currentTime < futureTime)
            {
                DisplayPrompt();
                Console.WriteLine();
                DisplayQuestions();
                currentTime = DateTime.Now;
                Console.WriteLine("\n");
            }

            DisplayEndingMessage();
        }
    }
}