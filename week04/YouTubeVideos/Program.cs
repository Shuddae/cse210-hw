using System;

class Program
{
    static void Main(string[] args)
    {
          Video video = new Video("My Video", "Will Smith", 300);

        Comment comment1 = new Comment("Antonio Barendes", "Great video!");
        Comment comment2 = new Comment("Michael Jackson", "Excellent content!");

        video.AddComment(comment1);
        video.AddComment(comment2);

        Console.WriteLine(video);
    }
    
}