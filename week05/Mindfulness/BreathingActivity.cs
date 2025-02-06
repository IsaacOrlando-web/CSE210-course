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
        public void Run()
        {
            DisplayStartingMessage();
            Console.Clear();
            Console.WriteLine($"Get Ready...");
            ShowSpinner();

            //Breath In and Breath out
            int time = 0;
            while(time != GetDuration())
            {
                Console.Write("\nBreath In...");
                ShowCountDown();
                Console.Write("\n");
                Console.Write("Breath out...");
                ShowCountDown();
                Console.Write("\n");

                //Ten by Ten until time is equal to the duration introduced by the user.
                time += 10;
            }
        }
    }
}