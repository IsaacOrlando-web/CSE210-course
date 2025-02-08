//Exceeding the requirements: i added a new animation at the end of the program, the animation is on the activity class, the method is call "DancingAnimation"
using System;
using System.Diagnostics;
using System.Collections.Generic;
using Mindfulness;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Mindfulness Project.");

        //Objects for every Activity
        Mindfulness.BreathingActivity breathingActivity= new Mindfulness.BreathingActivity();//Breathing Activity
        Mindfulness.ReflectingActivity reflectingActivity = new Mindfulness.ReflectingActivity();//Reflecting Activity
        Mindfulness.ListingActivity listingActivity = new Mindfulness.ListingActivity();
        int option = 0;

        //Menu
        while(option != 4)
        {
            Console.Clear();
            Console.WriteLine("Menu Options: ");
            Console.WriteLine(" 1. Start Breathing activity");
            Console.WriteLine(" 2. Start reflecting activity");
            Console.WriteLine(" 3. Start listing activity");
            Console.WriteLine(" 4. Quit");
            Console.Write("Select a choice from the menu: ");
            option = int.Parse(Console.ReadLine());

            if(option == 1)
            {
                breathingActivity.Run();
            }
            else if(option == 2)
            {
                reflectingActivity.Run();
            }
            else if(option == 3)
            {
                listingActivity.Run();
            }
            else if(option == 4)
            {
                break;
            }
            else
            {
                Console.WriteLine("Not valid number, in a few second enter a number again");
                Thread.Sleep(2000);
            }
        }

        Console.Clear();
        Console.WriteLine("Good-Bye");
        breathingActivity.DancingAnimation(5);
    }
}