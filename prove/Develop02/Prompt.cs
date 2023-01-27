public class Prompt
{
    //Generates a random prompt from a list of prompts, used in AddEntry method in Journal class
    public string PromptGenerator()
    {
        List<string> prompts = new List<string>(); 
        prompts.Add("What was the best thing that happened today?");
        prompts.Add("What is something that made you laugh today?");
        prompts.Add("What is one thing you want to remember from today?");
        prompts.Add("What is something you were grateful for today?");
        prompts.Add("Is there anything that you would have done differently today? If so, what?");
        
    
        Random r = new Random();
        int index = r.Next(prompts.Count);
        string randomPrompt = prompts[index]; 
        Console.WriteLine(randomPrompt);

        return randomPrompt;
    }
}