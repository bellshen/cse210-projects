using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Transactions;
public class Video
{
    public string _title;
    public string _author;
    public int _videoLength;

    List<Comment> _comments = new List<Comment>();
  
    public void AddComments(Comment comment)
    {
        _comments.Add(comment);
    }
    public void Display()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Video Length: {_videoLength} seconds");
        Console.WriteLine($"{_comments.Count} Comments:");

        foreach (Comment comment in _comments)
        {
            comment.Display();
        }
        Console.WriteLine();
    }
}