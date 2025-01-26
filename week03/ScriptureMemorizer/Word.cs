//Keeps track of a single word and whether it is shown or hidden.
namespace ScriptureMemorizer
{
    public class Word
    {
        //Method
        private string _text;
        private bool _isHidden;

        //Constructor
        public Word(string text)
        {
            _text = text;
            _isHidden = false; //Visible by default
        }

        //Behaviors
        //hide and show a word and to check if a word is hidden or not.
        public void Hide()
        {
            _isHidden = true;//if the word were hidden, this behavior would return underscores (for example, "______").
        }

        public void Show()
        {
            Console.WriteLine(_text); //The word class is to show
        }

        public bool IsHidden() 
        {
            return _isHidden; //The word class is to hide
        }

        public string GetDisplayText()
        {
            return _isHidden ? "____" : _text;
        }
    }
}