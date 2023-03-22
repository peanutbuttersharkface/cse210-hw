using System;

public class Comment{
    public string _commenter;
    public string _comment;
    public void DisplayComment(){
        Console.WriteLine($"Name of Commenter:{_commenter}, {_comment}");
    }
}