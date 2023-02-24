class Activity
{
    protected string _activityName;

    protected string _description;
    
    protected int _duration;
   
    public Activity()
    {
        
       
    }

    
    //Constructor that accepts activity name
    public Activity(string activityName)
    {
        _activityName = activityName;
    }
    

    
    //Constructor that accepts activity name and activity description
    public Activity(string activityName, string description)
    {
        _activityName = activityName;
        _description = description;
    }
    

    public Activity(string activityName, string description, int duration)
    {
        _activityName = activityName;
        _description = description;
        _duration = duration;
    }
    


    public Activity(int duration)
    //Constructor that accepts duration and activity name
    {
        _duration = duration;
    }

    public string GetActivityName(string _activityName)
    {
        return $"Welcome to the {_activityName} activity.";
    }

    public void SetActivityName(string activityName)
    {
        this._activityName = activityName;
    }

    public string GetDescription(string _description)
    {
        return $"{_description}";
    }

    public void SetDescription(string description)
    {
        _description = description;
    }

    public string GetDuration(int _duration)
    {
        return $"{Convert.ToInt32(_duration)}";
    }

    public void SetDuration(int duration)
    {
        _duration = duration;
    }
    

    public string GetCompleted()
    {
        return $"You have completed {_duration} seconds of the {_activityName} Activity. ";
    }
    
 

    //Spin animation
    public void spinAnimation()
    {
        Console.Write("/");
        Thread.Sleep(300);
        Console.Write("\b \b"); // Erase the / character
        Console.Write("-"); // Replace it with the - character
        Thread.Sleep(300);
        Console.Write("\b \b"); // Erase the - character
        Console.Write("\\"); // Replace it with the \ character
        Thread.Sleep(300);
        Console.Write("\b \b"); // Erase the \ character
        Console.Write("|"); // Replace it with the | character
        Thread.Sleep(300);
        Console.Write("\b \b"); // Erase the | character
        Console.Write("/"); // Replace it with the / character
        Thread.Sleep(300);
        Console.Write("\b \b"); // Erase the / character
        Console.Write("-"); // Replace it with the - character
        Thread.Sleep(300);
        Console.Write("\b \b"); // Erase the - character
        Console.Write("\\"); // Replace it with the \ character
        Thread.Sleep(300);
        Console.Write("\b \b"); // Erase the \ character
        Console.Write("|"); // Replace it with the | character
        Thread.Sleep(300);
        Console.Write("\b \b"); // Erase the | character
    }

    public void countdown()
    {
        Console.Write("5");
        Thread.Sleep(1000);
        Console.Write("\b \b"); // Erase the 5 character
        Console.Write("4"); // Replace it with the 4 character
        Thread.Sleep(1000);
        Console.Write("\b \b"); // Erase the 4 character
        Console.Write("3"); // Replace it with the 3 character
        Thread.Sleep(1000);
        Console.Write("\b \b"); // Erase the 3 character
        Console.Write("2"); // Replace it with the 2 character
        Thread.Sleep(1000);
        Console.Write("\b \b"); // Erase the 2 character
        Console.Write("1"); // Replace it with the 1 character
        Thread.Sleep(1000);
        Console.Write("\b \b"); // Erase the 2 character
    }

    public void wellDone()
    {
        Console.WriteLine("\nWell done!!");
        spinAnimation();
        Console.WriteLine(GetCompleted());
    }



}