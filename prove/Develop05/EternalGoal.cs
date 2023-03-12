//Lifelong goal
class EternalGoal : Goal
{

    //Constructor that accepts name, description and points
    public EternalGoal(string name, string description, int point) : base(name, description, point)
    {
        
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
        Console.WriteLine($"[ ] {_name} ({_description})");
    }

    public override string GoalType()
    {
        return "Eternal Goal";
    }


}