using System;
using Homework;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Homework Project.");

        MathAssignment mathAssignment = new MathAssignment("Isaac Maldonado", "Fractions and Natural Numbers", "7.1", "10-30");
        Console.WriteLine(mathAssignment.GetHomeworkList());
    }
}