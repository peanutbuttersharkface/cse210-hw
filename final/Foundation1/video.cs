using System;
using System.Collections.Generic;

public class Video{
    public string _title;
    public string _author;
    public int _length;
    public List<Comment> _comments = new List<Comment>();
     

    public void listComments()
{
    Console.WriteLine($"Video Title:{_title}");
    Console.WriteLine($"Video Author:{_author}");
    Console.WriteLine($"Video length:{_length} seconds");
    Console.WriteLine($"Number of Comments:{_comments.Count}");
    Console.WriteLine("Comments:");
        foreach (Comment comment in _comments)
        {
            comment.DisplayComment();
        }
}

    
}