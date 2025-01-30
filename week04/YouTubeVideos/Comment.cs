namespace YouTubeVideos
{
    public class Comment
    {
        private string _NameUser;
        private string _ComentText;

        //Constructor
        public Comment(string NameUser, string Comment)
        {
            _NameUser = NameUser;
            _ComentText = Comment;
        }

        public Comment()
        {
            _NameUser = "";
            _ComentText = "";
        }

        public string GetNameUser()
        {
            return _NameUser;
        }
        public string GetComment()
        {
            return _ComentText;
        }
    }
}