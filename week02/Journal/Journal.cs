using System;

namespace JournalApp
{
    public class Journal
    {
        public List<Entry> _entries = new List<Entry>();

        //AddEntry
        public void AddEntry(Entry entry)
        {
            _entries.Add(entry);
        }

        //show entries
        public void ShowEntries()
        {
            for(int i=0; i<_entries.Count; i++)
            {
                Console.WriteLine($"\nDate: {_entries[i]._date}");
                Console.WriteLine($"Prompt: {_entries[i]._promptText}");
                Console.WriteLine($"Response: {_entries[i]._entryText}");
            }
        }

        public void SaveToFile(List<Entry> entries)
        {
            Console.WriteLine("Saving to file...");

            string filename = "journal.txt";

            using (StreamWriter outputFile = new StreamWriter(filename))
            {
                for(int i=0; i<_entries.Count; i++)
                {
                    outputFile.WriteLine($"\nDate: {_entries[i]._date}");
                    outputFile.WriteLine($"Prompt: {_entries[i]._promptText}");
                    outputFile.WriteLine($"Response: {_entries[i]._entryText}");
                }
            }
        }
    }
}