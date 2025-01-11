using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");

        //call the disoplay welcome method
        DispplayWelcome();

        Console.WriteLine("Please enter your name:");
        string name = Console.ReadLine();

        string nameUser = PromptUserName(name);

        int userNumber = PromptUserNumber();

        int squareNumber = SquareNumber(userNumber);

        DisplayResult(nameUser, squareNumber);
    }

    // Displays the message, "Welcome to the Program!"
    static void DispplayWelcome()
    {
        Console.WriteLine("Welcome to the program");
    }

    static string PromptUserName(string name)
    {
        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number:");
        return int.Parse(Console.ReadLine());
    }

    static int SquareNumber(int number)
    {
        return number * number;
    }

    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"Brother {name}, the square fo your number is {square}");
    }
}