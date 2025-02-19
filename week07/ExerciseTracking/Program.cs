using System;
using ExerciseTracking;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ExerciseTracking Project.");

        List<Activity> activities = new List<Activity>();
        activities.Add(new Running(DateTime.Now, 30, 3.0));
        activities.Add(new Cycling(DateTime.Now, 45,15.0));
        activities.Add(new Swimming(DateTime.Now, 60, 20));

        //print the information
        foreach(var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}