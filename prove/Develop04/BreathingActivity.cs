class BreathingActivity : Activity
{
   

    public BreathingActivity()
    {

    }

    /*
    public BreathingActivity(string description)
    {
        _description = description;
    }
   
    public int GetDuration()
    {
        return _duration;
    }
    */

    //Start breathing activity 
    public void StartBreathingActivity()
    {
        Console.WriteLine(GetActivityName("Breathing"));
        Console.WriteLine();
        Console.WriteLine(GetDescription("This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing."));
        Console.WriteLine();
        Console.WriteLine("How long, in seconds, would you like this session to be? ");
        int _duration = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\nGet Ready...");
        spinAnimation();

        int milliseconds = 0;

        while (milliseconds < _duration)
        {
            Console.WriteLine("\nBreath in...");
            //Pausing for 4 seconds
            Thread.Sleep(4000);
            milliseconds += 4;
            Console.WriteLine("\nNow breath out...");
            //Pausing for 4 seconds
            Thread.Sleep(4000);
            milliseconds += 4;

            if (milliseconds >= _duration)
            {
                Console.WriteLine("\nWell done!!");
                spinAnimation();
                Console.WriteLine($"\nYou have completed {_duration} seconds of the Breathing Activity.\n");
            }
            
        }
    }
    
}