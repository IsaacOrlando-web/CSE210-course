using System;

namespace JournalApp
{
    public class Encourage
    {
        public List<string> congrats = [
        "Writing in your journal helps you organize your thoughts and emotions.",
        "Keeping a journal strengthens your memory and improves your writing skills.",
        "A journal is a safe space to reflect and get to know yourself better.",
        "Recording your days will allow you to appreciate your personal growth over time.",
        "Writing can reduce stress and help you find clarity in difficult moments.",
        "Maintaining a journal can inspire you and help you set clearer goals.",
        "Noting down your daily achievements boosts your self-esteem and confidence.",
        "Writing in your journal is an act of self-care and self-love."
        ];

        public string GetRandomCongrat()
        {
            Random random = new Random();
            int index = random.Next(congrats.Count);
            return congrats[index];
        }
    }
}