using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

        // The random number
        Random random = new Random();
        int number = random.Next(1, 100);
        string userInput = "";
        int userNumber;
        int triesnumber = 0;

        Console.WriteLine("What is the magic number? " + number);

        do
        {
            Console.Write("What is your guess?");
            userInput = Console.ReadLine();
            userNumber = int.Parse(userInput);
            if(userNumber == number){
                Console.WriteLine("You guessed it!");
            } 
            else if (userNumber < number){
                Console.WriteLine("Higher");
            } else {
                Console.WriteLine("Lower");
            }

            triesnumber++;
        }while (userNumber != number);

        //show the number of tries
        Console.WriteLine($"Number of tries: {triesnumber}");
        
    }
}