//Exeeding the Requirements: I added a menu where the user can choose between three scriptures to memorize. The program shows three options with their references:
//1 Nephi 3:6-7
//Moses 1:39
//1 Corinthians 6:19-20
//The user selects a number, and based on their choice, the program creates a Scripture object with the corresponding reference and text. Then, the user can practice memorizing the scripture, with some words being hidden randomly. The process continues until the user types "quit" or all the words are hidden, at which point the program congratulates the user.

using System;
using ScriptureMemorizer;

class Program
{
    static void Main(string[] args)
    {

        //The three scriptures references
        Reference reference1 = new Reference("1 Nephi", 3, 6, 7);
        Reference reference2 = new Reference("Moses", 1, 39);
        Reference reference3 = new Reference("1 Corinthians", 6, 19, 20);
        String option = ""; //The option to enter
        int scriptureOption = 0;
        Scripture scripture = null;

        Console.WriteLine("Choose a scripture to memorize:");
        Console.WriteLine("1. 1 Nephi 3:6-7");
        Console.WriteLine("2. Moses 1:39");
        Console.WriteLine("3. 1 Corinthians 6:19-20");

        Console.Write("Type the number: ");
        scriptureOption = int.Parse(Console.ReadLine());
        if(scriptureOption == 1)
        {
            scripture = new Scripture(reference1,"Therefore go, my son, and thou shalt be favored of the Lord, because thou hast not murmured. And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.");
        }
        else if(scriptureOption == 2)
        {
            scripture = new Scripture(reference2,"For behold, this is my work and my glory—to bring to pass the immortality and eternal life of man.");
        }
        else if(scriptureOption == 3)
        {
            scripture = new Scripture(reference3,"What? know ye not that your body is the temple of the Holy Ghost which is in you, which ye have of God, and ye are not your own? For ye are bought with a price: therefore glorify God in your body, and in your spirit, which are God’s.");
        }

        Random random = new Random();
        int randomNumber = random.Next(1,5); //Numbers of words that are going to hide

        //Testing the Scripture Class

        do{
            //Show the reference and text
            Console.WriteLine(scripture.GetDisplayText());

            //Verify if all words are hidden or not
            if(scripture.IsCompletelyHidden())
            {
                Console.WriteLine("Good Job");
                break; //End of the program, all words are Hidden.
            }

            //Enter Option
            Console.Write($"\nProgress enter to continue or type 'quit' to finish: ");
            option = Console.ReadLine();
            //Hide some Words
            scripture.HideRandomWords(randomNumber);
            Console.Clear();
        }while(option != "quit");
    }
}