using System;
using JournalApp;

class Program
{
    static void Main(string[] args)
    {
        //Prompt Generator
        PromptGenerator generator = new PromptGenerator();
        string randomPrompt = "";
        Journal journal = new Journal();

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
                    break;

                case 2:
                    //Display the Entry
                    Console.WriteLine("\nShowing the entries");
                    journal.ShowEntries();
                    break;
                case 3:
                    //Load the file
                    //journal.LoadFromFile();
                    break;
                case 4:
                    //Save the file
                    Console.WriteLine("Saving into the file: journal.txt");
                    journal.SaveToFile(journal._entries);
                    break;

            }
        }while(option != 5);
    }
}