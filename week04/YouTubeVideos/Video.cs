using System;
using System.Dynamic;

namespace YouTubeVideos
{
    public class Video
    {
        string _Title;
        string _ContentAuthor;
        string _Length;

        public List<Comment> _comments = new List<Comment>();

        //Constructors
        public Video(string title, string author, string lenght)
        {
            _Title = title;
            _ContentAuthor = author;
            _Length = lenght;
        }

        //Methods
        public void AddComment(string nameuser, string comment)//Stores a list of Comments
        {
            Comment NuevoComentario = new Comment(nameuser, comment);
            _comments.Add(NuevoComentario);
        }
        //Display all the comments
        public void DisplayAllComments()
        {
            foreach (Comment comment in _comments)
            {
                Console.WriteLine("User Name: " + comment.GetNameUser());
                Console.WriteLine("Comment: " + comment.GetComment());
            }
        }

        //Return the number of comments
        public int NumberOfComments()
        {
            return _comments.Count;
        }

        //Display All The information of the Video
        public void DisplayAllInfo()
        {
            Console.WriteLine($"Title: {_Title}\nAuthor: {_ContentAuthor}\nLength: {_Length} SEC.");
        }

    }
}