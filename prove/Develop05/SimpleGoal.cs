//One time achievment goal
class SimpleGoal : Goal
{
    private List<Goal> _simpleGoals = new List<Goal>();

    //Constructor that accepts no value
    public SimpleGoal()
    {

    }
    //Constructor that accepts name, description and points
    public SimpleGoal(string name, string description, int point) : base(name, description, point)
    {
        
    }


        public void StartSimpleGoal()
    {
        Console.WriteLine("What is the name of your goal? ");
        _name = Console.ReadLine();
        Console.WriteLine("What is a short description of it? ");
        _description = Console.ReadLine();
        Console.WriteLine("What is the amount of points associated with this goal? ");
        _point = int.Parse(Console.ReadLine());
    }



}