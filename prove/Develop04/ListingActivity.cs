class ListingActivity : Activity
{


    public ListingActivity()
    {
    

    }

//Method stores list of prompts and randomly selects one
    public string promptGenerator()
        {
            List<string> prompts = new List<string>();
            prompts.Add("Who are people that you appreciate?");
            prompts.Add("What are personal strengths of yours?");
            prompts.Add("Who are people that you have helped this week?");
            prompts.Add("Who are some of your personal heroes?");
            prompts.Add("List your accomplishments this week, no matter how small or big.");

            Random r = new Random();
            int index = r.Next(prompts.Count);
            string randomPrompt = prompts[index];

            Console.WriteLine(randomPrompt);
            return randomPrompt;
        }


    public void StartListingActivity()
    {
        Console.WriteLine(GetActivityName("Listing"));
        Console.WriteLine();

        Console.WriteLine(GetDescription("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area."));
        Console.WriteLine();

        Console.WriteLine("How long, in seconds, would you like this session to be? ");
        int _duration = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Get ready...");
        spinAnimation();
        Console.Clear();
        Console.WriteLine("\nList as many responses you can to the following prompt: ");
        promptGenerator();

        Console.Write("\nYou may begin in: ");
        //method from Activity.cs - visual countdown 4 seconds
        countdown();

        Console.WriteLine();
        //Assigns current date and time to variable called currentTime
        DateTime currentTime = DateTime.Now;
        //Adds the seconds user entered to the current time and stores in variable called futureTime
        DateTime futureTime = currentTime.AddSeconds(_duration);
        //Allows user to input list while current time is less than future time.
        while (currentTime < futureTime)
        {
            Console.ReadLine();

            if (DateTime.Now > futureTime)
        {
        Console.WriteLine("\nWell done!!");
        spinAnimation();
        Console.WriteLine($"\nYou have completed {_duration} seconds of the Listing Activity.\n");
        }
        }
        
    }

}



