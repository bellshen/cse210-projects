public class Comment
{
    public string _commenter;
    public string _commentText;

    public void Display()
    {
        Console.WriteLine($"{_commenter} : {_commentText}");
    }
}