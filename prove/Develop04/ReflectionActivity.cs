class ReflectionActivity : Activity
{
    private List<string> reflectionQuestions;

    public ReflectionActivity()
        {
            //List of reflection questions that will be presented to user in StartReflectionActivity method
            reflectionQuestions = new List<string>();
            reflectionQuestions.Add("Why was this experience meaningful to you?");
            reflectionQuestions.Add("How did you feel when it was complete?");
            reflectionQuestions.Add("What is your favorite thing about this experience?");
            reflectionQuestions.Add("What is one thing that really stood out to you during this experience?");
            reflectionQuestions.Add("Is there anything you would have changed about this experience if you could?");

        }

    //Method stores a list of reflection prompts and randomly selects one
    public string reflectionGenerator()
    {
        List<string> reflections = new List<string>();
        reflections.Add("Think of a time when you did something really difficult.");
        reflections.Add("Think of a time when you stood up for someone else");
        reflections.Add("Think of a time when you helped someone in need.");
        reflections.Add("Think of a time you accomplished a goal you had set for yourself.");

        Random r = new Random();
        int index = r.Next(reflections.Count);
        string randomReflection = reflections[index];

        Console.WriteLine(randomReflection);
        return randomReflection;
    }

    public void StartReflectionActivity()
    {
       
        Console.WriteLine(GetActivityName("Reflection"));
        Console.WriteLine();

        Console.WriteLine(GetDescription("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life."));
        Console.WriteLine();

        Console.WriteLine("How long, in seconds, would you like this session to be? ");
        int _duration = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Get ready...");
        spinAnimation();

        Console.WriteLine("\nConsider the following prompt:\n");
        reflectionGenerator();

        Console.WriteLine("\nWhen you have something in mind, press enter to continue.");
        bool enterInput = Console.ReadLine() == "";

        if (enterInput)
        {
            Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
            Console.Write("You may begin in: ");
            //method from Activity.cs - visual countdown 4 seconds
            countdown();
            Console.Clear();
        }
            
            int milliseconds = 0;
         
            foreach (string question in reflectionQuestions)
            {
                
                Console.Write(question);
                //Pausing for 4 seconds
                Thread.Sleep(4000);
                Console.WriteLine(); 
                milliseconds += 4;
                if(milliseconds >= _duration)
                {
                    Console.WriteLine("\nWell done!!");
                    spinAnimation();
                    Console.WriteLine($"\nYou have completed {_duration} seconds of the Reflection Activity.\n");
                    break;
                }
            } 
    }
}