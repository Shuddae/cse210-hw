using System;

class Program
{
    static void Main(string[] args)
    {
          Video video = new Video("My Video", "John Doe", 300);

        Comment comment1 = new Comment("Jane Doe", "Great video!");
        Comment comment2 = new Comment("Bob Smith", "Excellent content!");

        video.AddComment(comment1);
        video.AddComment(comment2);

        Console.WriteLine(video);
    }
    
}