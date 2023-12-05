using System.Reflection;

public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public int NumberOfComments()
    {
        return _comments.Count();
    }

    public void CreateComment(string name, string text)
    {
        Comment newComment = new Comment(name, text);
        _comments.Add(newComment);
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"VIDEO: {_title} - {_author} ({_length}secs)");
        Console.WriteLine();
        
        int commentCount = NumberOfComments();

        Console.WriteLine($"Number of Comments: {commentCount}");

        foreach (Comment comment in _comments)
        {
            comment.DisplayComment();
        }
    }
}