using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Learn Python", "John", 600);
        video1.AddComment(new Comment("Mary", "Great video!"));
        video1.AddComment(new Comment("Peter", "Very helpful!"));
        video1.AddComment(new Comment("Anna", "Thank you!"));
        videos.Add(video1);

        Video video2 = new Video("Learn C#", "David", 450);
        video2.AddComment(new Comment("John", "Good explanation!"));
        video2.AddComment(new Comment("Mary", "I like this video!"));
        video2.AddComment(new Comment("Peter", "Easy to understand!"));
        videos.Add(video2);

        Video video3 = new Video("HTML Basics", "Sarah", 300);
        video3.AddComment(new Comment("Anna", "Nice tutorial!"));
        video3.AddComment(new Comment("David", "Very interesting!"));
        video3.AddComment(new Comment("John", "Thanks for sharing!"));
        videos.Add(video3);

        foreach (Video video in videos)
        {
            video.Display();
            Console.WriteLine();
        }
    }
}
