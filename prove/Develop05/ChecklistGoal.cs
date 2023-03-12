//Goal series -- allows user to enter how many times they want to accomplish this goal
class ChecklistGoal : Goal
{
    private int _numberOfTimes;
    private int _bonus;
    private int _completed;

    //Constructor that accepts name, description and points
    public ChecklistGoal(string name, string description, int point, int bonus, int numberOfTimes, int completed) : base(name, description, point)
    {
        _numberOfTimes = numberOfTimes;
        _bonus = bonus;
        _completed = completed;
    }

        public override void GetGoal()
    {
        string filename = "";
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");
            string _goalType = parts[0];
            string _name = parts[1];
            string _description = parts[2];
            string _point = parts[3];
        }
        Console.WriteLine($"{_goalType}: {_name} {_description} {_point}");
    }

     public override void DisplayGoal()
    {
        Console.WriteLine($"[ ] {_name} ({_description}) -- Currently completed: 0/{_numberOfTimes}");
    }

    public override string GoalType()
    {
        return "Checklist Goal";
    }



}