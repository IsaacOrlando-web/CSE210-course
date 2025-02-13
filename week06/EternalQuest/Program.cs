using System;
using EternalQuest;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the EternalQuest Project.");

        SimpleGoal simpleGoal = new SimpleGoal("Finish my programming project", "Today i'd like to finish all my programming project and submit it", 20);

        simpleGoal.RecordEvent();
        Console.WriteLine(simpleGoal.GetIsCompleted());
        Console.WriteLine(simpleGoal.GetIsCompleted());
        Console.WriteLine(simpleGoal.GetStringRepresentation());
    }
}