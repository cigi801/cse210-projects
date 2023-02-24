class BreathingActivity : Activity
{
   

    public BreathingActivity()
    {

    }


    //base.SetDuration(duration);


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
            Console.Write("\nBreath in... ");
            //Pausing for 5 seconds
            countdown();
            milliseconds += 5;
            Console.Write("\nNow breath out... ");
            //Pausing for 5 seconds
            countdown();

            milliseconds += 5;

            if (milliseconds >= _duration)
            {
                Console.WriteLine();
                Console.WriteLine("\nWell done!!");
                spinAnimation();
                Console.WriteLine($"\nYou have completed {_duration} seconds of the Breathing Activity.\n");
            }
            
        }
    }
    
}