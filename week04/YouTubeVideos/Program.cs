using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");
        Console.WriteLine();
        
        //Create Video1
        Video v1 = new Video();
        v1._title = "Consider The Lilies";
        v1._author = "The Best Choir";
        v1._videoLength = 130;

        Comment v1Comment1 = new Comment();
        v1Comment1._commenter = "Alice";
        v1Comment1._commentText = "Beautiful music.";
        v1.AddComments(v1Comment1);

        Comment v1Comment2 = new Comment();
        v1Comment2._commenter = "Julia";
        v1Comment2._commentText = "This is the best vesion I've ever heard.";
        v1.AddComments(v1Comment2);

        Comment v1Comment3 = new Comment();
        v1Comment3._commenter = "Mica";
        v1Comment3._commentText = "This music heals my soul!";
        v1.AddComments(v1Comment3);

        Comment v1Comment4 = new Comment();
        v1Comment4._commenter = "Stephanie";
        v1Comment4._commentText = "I love the arrangement, it is so beautiful.";
        v1.AddComments(v1Comment4);

        //Create Video2
        Video v2 = new Video();
        v2._title = "I Am A Child Of God";
        v2._author = "Our Ward Choir";
        v2._videoLength = 80;

        Comment v2Comment1 = new Comment();
        v2Comment1._commenter = "Adam";
        v2Comment1._commentText = "This is my favorite music.";
        v2.AddComments(v2Comment1);

        Comment v2Comment2 = new Comment();
        v2Comment2._commenter = "Gabriel";
        v2Comment2._commentText = "How lovely! My kids like to sing with this video.";
        v2.AddComments(v2Comment2);

        Comment v2Comment3 = new Comment();
        v2Comment3._commenter = "Christine";
        v2Comment3._commentText = "Sound from heaven!";
        v2.AddComments(v2Comment3);

        //Create Video3
        Video v3 = new Video();
        v3._title = "Love At Home";
        v3._author = "Hsinchu Stake Conference Choir";
        v3._videoLength = 137;

        Comment v3Comment1 = new Comment();
        v3Comment1._commenter = "Elice";
        v3Comment1._commentText = "Beautiful choir!";
        v3.AddComments(v3Comment1);

        Comment v3Comment2 = new Comment();
        v3Comment2._commenter = "Joshua";
        v3Comment2._commentText = "The piano accompaniment is so beautiful. This is the best version of the arrangement I have ever heard.";
        v3.AddComments(v3Comment2);

        Comment v3Comment3 = new Comment();
        v3Comment3._commenter = "Grace";
        v3Comment3._commentText = "The favorite song in our family home evening.";
        v3.AddComments(v3Comment3);

        Comment v3Comment4 = new Comment();
        v3Comment4._commenter = "Timothy";
        v3Comment4._commentText = "The arrangement is so beautiful.";
        v3.AddComments(v3Comment4);

        //Put each of these videos in a list.
        List<Video> videos = new List<Video>{v1,v2,v3};

        //Display result
        foreach (Video video in videos)
        {
            video.Display();
        }
    }
}