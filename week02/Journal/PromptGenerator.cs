using System;

namespace JournalApp
{
    public class PromptGenerator
    {
        public List<string> Prompts = ["List three things you're grateful for today, no matter how small. How do they add value to your life?", " What was the best part of your day? Why did it stand out to you, and how can you create more moments like it?", "What is one area of your life you'd like to improve? Write about a small step you can take today to work toward that goal.", "How are you feeling right now? Explore why you feel this way and what actions (if any) you might take to process or embrace this emotion.", "Reflect on a recent challenge or mistake. What did it teach you, and how will you apply this lesson moving forward?"];

        public string GetRandomPrompt()
        {
            Random random = new Random();
            int index = random.Next(Prompts.Count);
            return Prompts[index];
        }
    }
}