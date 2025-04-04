using System;


public class Comment
{
     public string Username;
    public string Text;

    public Comment(string username, string text)
    {
        Username = username;
        Text = text;
    }

    public override string ToString()
    {
        return $"{Username}: {Text}";
    }
}

    
