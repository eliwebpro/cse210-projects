using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

public class Video
{
    private string _title;
    private string _author;
    private int _lengthMin;
    private int _lengthSec;
    private List<Comment> _comments;

    public Video(string title, string author, int lengthMin, int lengthSec)
    {
        _title = title;
        _author = author;
        _lengthSec = lengthSec;
        _lengthMin = lengthMin;
        _comments = new List<Comment>();
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public int GetNumberComments()
    {
        return _comments.Count;
    }

   private string LengthOfVideo()
    {
        return $"{_lengthMin:D2}:{_lengthSec:D2}";
    }


    public List<Comment>  GetComments()
    { 
        return _comments; 
    }
    public string GetDysplayText()
    {
        return $"Title: {_title}\nAuthor: {_author}\nLength: {LengthOfVideo()}\nNumber of Comments: {GetNumberComments()}";

    }  

    




}