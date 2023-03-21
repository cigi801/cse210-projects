using System;
using System.Collections.Generic;

class Comment
{
    protected string _person;
    protected string _comment;

    public Comment(string person, string comment)
    {
        _person = person;
        _comment = comment;
    }

    public void AddComment(string person, string comment)
    {
        person = _person;
        comment = _comment;
    }
    public string GetPerson()
    {
        return _person;
    }

    public void SetPerson(string person)
    {
        _person = person;
    }

    public string GetComment()
    {
        return _comment;
    }

    public void SetComment(string comment)
    {
        _comment = comment;
    }

    public void DisplayComments()
    {
        Console.WriteLine($"{_person}: {_comment}");
    }



    

}