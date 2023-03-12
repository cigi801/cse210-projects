//One time achievment goal
class SimpleGoal : Goal
{
    private bool _completed;
    private string _goalType;
    //Constructor that accepts name, description and points
    public SimpleGoal(string name, string description, int point, bool completed) : base(name, description, point)
    {
        _completed = completed;
    }

    

    public override void GetGoal()
    {
        string filename = "";
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");
            string _name = parts[1];
            string _description = parts[2];
            string _point = parts[3];
        }
        Console.WriteLine($"{GoalType()}: {_name} {_description} {_point} Completed? {_completed}");
    }

  
     public override void DisplayGoal()
    {
        Console.WriteLine($"[ ] {_name} ({_description})");
    }

    public override string GoalType()
    {
        return "Simple Goal";
    }



  



}