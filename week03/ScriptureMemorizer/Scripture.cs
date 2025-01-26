using System;

namespace ScriptureMemorizer
{
    //Keeps track of both the reference and the text of the scripture. Can hide words and get the rendered display of the text.
    public class Scripture
    {
        //Atributes
        //track of both the reference and the text of the scripture.
        Reference _reference = new Reference();//The data type for the reference is Reference, the custom class defined above. 

        public List<Word> _words = new List<Word>();//The data type for the list of words would be List<Word>
        

        //Constructor
        public Scripture()
        {
            _reference = new Reference(); // Inicializa un nuevo objeto Reference con valores predeterminados.
            _words = new List<Word>();    // Inicializa la lista de palabras como vacía.
        }
        public Scripture(Reference reference, string text)
        {
            _reference = reference;
            _words = SplitTextIntoWords(text);
        }

        //Split the text Into Words.
        private List<Word> SplitTextIntoWords(string text)
        {
            var wordList = new List<Word>();
            string[] splitWords = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            foreach (string word in splitWords)
            {
                wordList.Add(new Word(word));
            }

            return wordList;
        }

        public void ShowReferenceAndScripture()
        {
            Console.Write($"{_reference.GetDisplayText()}: ");
            for(int i = 0; i< _words.Count; i++)
            {
                Console.Write($"{_words[i].GetDisplayText()} ");
            }
        }

        //Function to HideRandomWords
        public void HideRandomWords(int numberToHide)
        {
            // Filtrar palabras visibles.
            var visibleWords = _words.Where(word => !word.IsHidden()).ToList();
        
            // Si no hay palabras visibles, no hacemos nada.
            if (visibleWords.Count == 0) return;
        
            // Ajustar el número de palabras a ocultar según las disponibles.
            numberToHide = Math.Min(numberToHide, visibleWords.Count);
        
            Random random = new Random();
            for (int i = 0; i < numberToHide; i++)
            {
                // Seleccionar un índice aleatorio de las visibles.
                int index = random.Next(visibleWords.Count);
        
                // Ocultar la palabra seleccionada.
                visibleWords[index].Hide();
        
                // Eliminarla de la lista temporal para evitar duplicados.
                visibleWords.RemoveAt(index);
            }
        }

        //The "display text" refers to the text with some words shown normally, and some replaced by underscores.
        public string GetDisplayText()
        {
            Console.Write($"{_reference.GetDisplayText()}: ");
            string displayText = "";

            foreach (Word word in _words)
            {
                displayText += word.IsHidden() ? "____ " : $"{word.GetDisplayText()} ";
            }
            return displayText.TrimEnd();
        }

        //It would also be nice to have a behavior to check if the scripture is completely hidden so that you know when to end the program.
        public bool IsCompletelyHidden()
        {
            return _words.All(Word => Word.IsHidden());
        }
    }
}