using System;
using EternalQuest;

class Program
{
    static void Main(string[] args)
    {
        EternalGoals eternal = new EternalGoals("Read Every day", "Read any book every day", 30);
        eternal.RecordEvent();
        Console.WriteLine(eternal.IsComplete());
        Console.WriteLine(eternal.GetStringRepresentation());
        Console.WriteLine(eternal.GetDetailsString());
    }
}