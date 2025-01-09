using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise1 Project.");

        Console.Write("What is your favorite first name? ");
        String fname = Console.ReadLine();
        
        Console.Write("What is your last name? ");
        String lname = Console.ReadLine();

        Console.WriteLine($"\nYour name is {lname}, {fname} {lname}.");
    }
}