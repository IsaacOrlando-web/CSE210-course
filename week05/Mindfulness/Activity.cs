using System;
using System.Collections.Generic;
using System.Threading;

namespace Mindfulness
{
    public class Activity
    {
        // Properties
        protected string _name;
        protected string _description;
        protected int _duration; 

        //Constructors
        public Activity()
        {
            _name = "Anonymous";
            _description = "Unkown";
            _duration = 1000;
        }

        public Activity(string name, string description, int duration)
        {
            _name = name;
            _description = description;
            _duration = duration;
        }

        //Get and Set
        public string GetName()
        {
            return _name;
        }

        public void SetName(string name)
        {
            _name = name;
        }

        public string GetDescription()
        {
            return _description;
        }
        public void SetDescription(string description)
        {
            _description = description;
        }

        public int GetDuration()
        {
            return _duration;
        }
        public void SetDuration(int duration)
        {
            _duration = duration;
        }

        //Methods
        public void DisplayStartingMessage()//Tested: Correct
        {
            Console.WriteLine($"Welcome to the {GetName()}");
            Console.WriteLine($"\n{GetDescription()}");

            bool MultiplyByTen = false; //If the number entered by the user is multiply by ten, can access to the program

            while(MultiplyByTen == false)
            {
                Console.Write("How many seconds would you like your session to be?: ");
                string input = Console.ReadLine();
                _duration = int.Parse(input);

                if(_duration % 10 == 0)
                {
                    MultiplyByTen = true;
                }
                else{
                    MultiplyByTen = false;
                    Console.WriteLine("Only a Number that is a multiple of ten");
                }
            }
            
        }

        public void DisplayEndingMessage()//We need the time
        {
            Console.WriteLine("Great job! Your hard work and dedication truly paid off. Keep up the amazing work!");
        }

        public void ShowSpinner() //Tested: Correct.
        {
            List<string> animationStrings = new List<string>();
            animationStrings.Add("|");
            animationStrings.Add("/");
            animationStrings.Add("-");
            animationStrings.Add("\\");
            animationStrings.Add("|");
            animationStrings.Add("/");
            animationStrings.Add("-");

            int i;

            for(i = 0; i<2; i++)
            {
                foreach(string s in animationStrings)
                {
                    Console.Write(s);
                    Thread.Sleep(1000);
                    Console.Write("\b \b");
                }
            }
        }

        public void DancingAnimation(int seconds)
        {
            string[] frames = {
                " (•_•) \n<)   )╯\n /   \\ ",  // Pose 1
                " (•_•) \n<)   )╯\n /   \\ ",  // Pose 2 (igual a la 1 para una pausa)
                " (•_•) \n<(   (>\n /   \\ ",  // Pose 3
                " (•_•) \n<(   (>\n /   \\ "   // Pose 4 (igual a la 3 para pausa)
            };

            int i = 0;
            DateTime endTime = DateTime.Now.AddSeconds(seconds);
            while (DateTime.Now < endTime)
            {
                Console.Clear();
                Console.WriteLine(frames[i % frames.Length]);  // Mostrar el muñeco
                Thread.Sleep(300);  // Velocidad de la animación
                i++;
            }

            Console.Clear();
            Console.WriteLine("¡Fin del baile!");
        }

        public void ShowCountDown()//Tested: Corrected
        {
            for(int i = 5; i >= 1; i--)
            {
                
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
        }

    }
}