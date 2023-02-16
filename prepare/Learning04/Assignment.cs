class Assignment
{
    protected string _studentName;
    protected string _topic;

    //Constructor accepts student name and topic
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    //Constructor accepts only student name
    public Assignment(string studentName)
    {
        _studentName = studentName;
    }

    //Getter for student name and topic summary
    public string GetSummary()
    {
        return $"Student: {_studentName} Topic: {_topic}";
    }

    //Setter for student name and topic summary
    public void SetSummary(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }



}