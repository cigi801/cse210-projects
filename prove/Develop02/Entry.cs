public class Entry
{
    //setting member variables for elements within 'Entry' class
   public string _dateText = "";
   public string _entry = "";
   public string _prompt = "";

    //method or member functions to display entry date, prompt and user entry
   public void DisplayEntry()
   {
    Console.WriteLine($"Date: {_dateText} - Prompt: {_prompt} \n{_entry}");
   } 
    public string Convert()
    {
        return $"Date: {_dateText} - Prompt: {_prompt} \n{_entry}";
    }

    //Entry class constructor
    public Entry()
    {

    }   
}