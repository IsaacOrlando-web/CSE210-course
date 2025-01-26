// Keeps track of the book, chapter, and verse information.
namespace ScriptureMemorizer
{
    public class Reference
    {
        private string _book;
        private int _chapter;
        private int _verse;
        private int _endVerse;

        //Constructors
        public Reference()
        {
            _book = "Unknown";   
            _chapter = 1;        
            _verse = 1;          
            _endVerse = 1;   
        }
        public Reference(string book, int chapter, int verse)
        {
            _book = book;
            _chapter = chapter;
            _verse = verse;
            _endVerse = verse;
        }

        public Reference(string book, int chapter, int startVerse, int endVerse)
        {
            _book = book;
            _chapter = chapter;
            _verse = startVerse;
            _endVerse = endVerse;
        }

        //Methods
        public string GetDisplayText()
        {
            if (_verse == _endVerse)
            {
                return $"{_book} {_chapter}:{_verse}";
            }
            else
            {
                return $"{_book} {_chapter}:{_verse}-{_endVerse}";
            }
        }//The Reference class is pretty simple as far as behaviors go. It should have the ability to get the display text of the reference, which is just a string combining the book, chapter, and verse (or verses). You could consider having getters and setters for each of the data elements that this class stores, but it may be even better to use a constructor to set them.
    }
}