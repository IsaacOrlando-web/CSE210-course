using System;
using System.Collections.Generic;
using System.Threading;

namespace Mindfulness
{
    public class ListingActivity : Activity
    {
        private int _count;
        private List<string> _prompts;

        private int _quantity; //it's gonna keep track of the number of responses from the user

        //Constructors
        public ListingActivity() : base()
        {
            _name = "Listing Activity";
            _description = "A reflecting activity is a structured moment of introspection to analyze thoughts, actions, and experiences. It fosters self-awareness, learning, and intentional change through journaling, meditation, or guided questions."; 
            _prompts = ["Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "Who are some of your personal heroes?"];

            _quantity = 0;
        }

        //Get and Set Quantity
        public int GetQuantity()
        {
            return _quantity;
        }
        public void SetQuantity(int quantity)
        {
            _quantity = quantity;
        }

        public string GetRandomPrompt() //Tested: Correct
        {
            Random random = new Random();
            string randomprompt = _prompts[random.Next(_prompts.Count)];

            return randomprompt;
        }

        public List<string> GetListFromUser()//Tested: Correct
        {
            List<string> list = new List<string>();
            DateTime startTime = DateTime.Now; //Create the datatime Object
            DateTime futureTime = startTime.AddSeconds(_duration); //The seconds entered by the user
            string input = "";
            
            int quantity = 0; //Quantity of items entered by the user

            DateTime currentTime = DateTime.Now;
            while(currentTime < futureTime) //Repeat this until the current time is iqual the future time(Seconds entered by the user).
            {
                currentTime = DateTime.Now; //Upload the time
                Console.Write(">");
                input = Console.ReadLine();
                list.Add(input);
                quantity++; //Counting the quantity(I create a new attribute for this class "private int quantity", to keep track of the number of items listed by the user).
                SetQuantity(quantity); //Set the quantity
            }

            return list; //Return the items from the list
        }

        public void Run() //Test: Correct
        {
            Console.Clear();
            DisplayStartingMessage();
            Console.Clear();

            Console.WriteLine($"----{GetRandomPrompt()}----");
            Console.WriteLine($"Get Ready...");
            ShowSpinner();
            GetListFromUser();

            Console.WriteLine("You Listed " + GetQuantity() + " items\n");
            DisplayEndingMessage();
        }
    }
}