class Goal
{
    protected string _name;
    protected string _description;
    protected int _point;
    protected int goalType;

    //Constructor that accepts no parameters
    public Goal()
    {

    }
    //Constructor that accepts name, description and points
    public Goal(string name, string description, int point)
    {
        _name = name;
        _description = description;
        _point = point;
    }

    //Goal name getter and setter
    public string GetName()
    {
        return _name;
    }

    public void SetName(string name)
    {
        _name = name;
    }

    //Goal description getter and setter
    public string GetDescription()
    {
        return _description;
    }

    public void SetDescription(string description)
    {
        _description = description;
    }

    //Point getter and setter
    public int GetPoint()
    {
        return _point;
    }

    public void SetPoint(int point)
    {
        _point = point;
    }

  

    public void GoalDetails()
    {
        Console.WriteLine("What is the name of your goal? ");
        _name = Console.ReadLine();
        Console.WriteLine("What is a short description of it? ");
        _description = Console.ReadLine();
        Console.WriteLine("What is the amount of points associated with this goal? ");
        _point = int.Parse(Console.ReadLine());
    }








}