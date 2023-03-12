abstract class Goal
{
    protected string _name;
    protected string _description;
    protected int _point;

    protected string _goalType;

    //Constructor that accepts name, description and points
    public Goal(string name, string description, int point)
    {
        _name = name;
        _description = description;
        _point = point;
    }
 
    public abstract void GetGoal();
  
    //public abstract string DisplayGoal();
    public abstract void DisplayGoal();

    public abstract string GoalType();



}