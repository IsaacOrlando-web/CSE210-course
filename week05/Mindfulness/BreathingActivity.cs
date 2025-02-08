using System;
using System.Collections.Generic;
using System.Threading;

namespace Mindfulness
{
    public class BreathingActivity : Activity
    {
        public BreathingActivity() : base()
        {
            _name = "Breathing Activity";
            _description = "This breathing activity is designed to help you relax, reduce stress, and refocus your mind. By following a simple rhythmic breathing pattern, you can calm your nervous system and enhance your overall well-being.";
        }
        public void Run() //Tested:Correct
        {
            
            DisplayStartingMessage();
            Console.WriteLine($"Get Ready...");
            ShowSpinner();

            DateTime startTime = DateTime.Now;
            DateTime futureTime = startTime.AddSeconds(_duration);
            //Breath In and Breath out
            DateTime currentTime = DateTime.Now;
            while(currentTime < futureTime)
            {
                Console.Write("\nBreath In...");
                ShowCountDown();
                Console.Write("\n");
                Console.Write("Breath out...");
                ShowCountDown();
                currentTime = DateTime.Now;//Update the time
                Console.Write("\n");
            }

            DisplayEndingMessage();
        }
    }
}