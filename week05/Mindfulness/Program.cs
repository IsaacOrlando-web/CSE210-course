using System;
using System.Diagnostics;
using System.Collections.Generic;
using Mindfulness;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Mindfulness Project.");

        Mindfulness.Activity activity = new Mindfulness.Activity("Bombing Activity", "This activity will help you to excersice", 1000);
        //activity.DisplayStartingMessage();
        //Console.Write(activity.GetDuration());
        //activity.DancingAnimation(3);

        Mindfulness.BreathingActivity breathingActivity = new Mindfulness.BreathingActivity();
        breathingActivity.Run();
    }
}