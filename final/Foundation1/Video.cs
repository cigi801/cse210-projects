using System;
using System.Collections.Generic;

class Video
{
    protected string _title;
    protected string _author;
    protected double _length;

   

    public List<Comment> comments = new List<Comment>();


    //constructor to include video name, author and length of video
    public Video(string title, string author, double length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    

    public int GetCommentCount()
    {
        return comments.Count;
    }

    public void AddComment(Comment comment)
    {
        comments.Add(comment);
    }


    public void DisplayVideo()
    {
        Console.WriteLine($"\nVideo: {_title} \nAuthor: {_author} \nLength: {_length} seconds");
        Console.WriteLine($"Comments: {GetCommentCount()}\n");

        foreach(Comment comment in comments)
        {
            comment.DisplayComments();
        }
    }






}