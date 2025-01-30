using System;
using YouTubeVideos;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");

        Video video1 = new Video("How to Use .NET", "John Squares", "30");
        video1.AddComment("Alex Vargas", "Thanks a lot for this tutorial, it was Great");
        video1.AddComment("Juan Schegel", "Ey, thanks for your video, it helped me a lot with my university project");
        video1.AddComment("Isaac Maldonado", "For your video i could improve in using .NET in my project, i'm very thankfull for that");

        Console.WriteLine("----Video Information----");
        video1.DisplayAllInfo();
        Console.WriteLine($"Comments: {video1.NumberOfComments()}");
        video1.DisplayAllComments();

        Video video2 = new Video("Minecraft Gameplay", "Rubius", "20");
        video2.AddComment("Juan Camus", "I love that Game so much");
        video2.AddComment("Carlos cifuentes", "That's my favorite Game");
        video2.AddComment("Isaac Maldonado", "i don't like that Game i prefer FNAF");
        video2.AddComment("Lucas Maldonado", "I love that part of the game");

        Console.WriteLine("\n----Video Information----");
        video2.DisplayAllInfo();
        Console.WriteLine($"Comments: {video1.NumberOfComments()}");
        video2.DisplayAllComments();

        Video video3 = new Video("Nietzche's Philosophy", "PhilosophyExplained", "100");
        video3.AddComment("Michael Camus", "I think Friedrich Nietzche's point of view is very interesting");
        video3.AddComment("Isaac Maldonado", "Finally a place where i can understand Nietzche's philosophy, for me Nietzche has been one of the philosophers with the most complex ideas, thanks a lot, i have a test tomorrow on my university about this subject.");

        Console.WriteLine("\n----Video Information----");
        video3.DisplayAllInfo();
        Console.WriteLine($"Comments: {video1.NumberOfComments()}");
        video3.DisplayAllComments();
    }
}