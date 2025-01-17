using System;
using System.Collections.Generic;

namespace JournalApp
{
    public class Entry
    {
        public string _date;
        public string _promptText;
        public string _entryText;

        public Entry(string date, string promptText, string entryText)
        {
            _date = date;
            _promptText = promptText;
            _entryText = entryText;
        }

        public Entry() { } // Constructor sin parámetros


        // Método para mostrar todas las entradas
        public void Display()
        {
            Console.WriteLine(_date);
            Console.WriteLine(_promptText);
            Console.WriteLine(_entryText);
        }
    }
}