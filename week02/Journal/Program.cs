//Exceeding Requirements: One of the reasons people struggle to write in their journal is that they don't fully understand why it's important. So, I plan to create a class with a method that congratulates the person for writing in their journal and randomly reminds them of one of the benefits of journaling. This way, the program offers encouragement and support.
//UPdate: I made the program more user-friendly, turning it into a virtual assistant called "Journalito" to support and encourage journal writers. Journalito congratulates the writer warmly and shares a random benefit of journaling to motivate them to keep up the habit.

using System;
using JournalApp;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        //Prompt Generator
        PromptGenerator generator = new PromptGenerator();
        string randomPrompt = "";
        Journal journal = new Journal();

        Console.WriteLine("Welcome to the Journal App!, I'm Journalito, your virtual assistant. I'm here to help you write in your journal and provide you with encouragement and support. Let's get started!");

        //Menu
        int option = 0;
        do{
            Console.WriteLine("\nMenu");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Exit");
            Console.Write("Enter an option: ");
            option = Convert.ToInt32(Console.ReadLine());

            switch(option){
                case 1:
                    //Create a new entry
                    Entry entry = new Entry();

                    //Show the Random Prompt
                    randomPrompt = generator.GetRandomPrompt();
                    Console.WriteLine("\n" + randomPrompt);

                    //Save the information into the object Entry
                    entry._promptText = randomPrompt;  //The Random Prompt
                    entry._date = DateTime.Now.ToString("MM/dd/yyyy"); //The date

                    //Enter the response
                    Console.Write(">");
                    string entryText = Console.ReadLine(); //enter the response

                    //Save the response into the object Entry
                    entry._entryText = entryText;

                    //Add the entry into the journal
                    journal.AddEntry(entry);

                    //Congrats and Encouragement
                    Encourage encourage = new Encourage();
                    string randomCongrat = encourage.GetRandomCongrat();
                    Console.WriteLine("Journalito Assistant: Good Job!! :D " + randomCongrat);
                    break;

                case 2:
                    //Display the Entry
                    Console.WriteLine("\nShowing the entries");
                    journal.ShowEntries();
                    break;
                case 3:
                    //Load the file
                    journal.LoadFromFile("journal.txt");
                    break;
                case 4:
                    //Save the file
                    Console.WriteLine("Saving into the file: journal.txt");
                    journal.SaveToFile(journal._entries);
                    break;

            }
        }while(option != 5);
        Console.WriteLine("Journalito Assistant: Goodbye! Have a great day!, remember come back and tell me more about your Great Experiences and Progress! :D");
    }
}