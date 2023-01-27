public class Journal
{
    //instantiate class instances
    Prompt prompt = new Prompt();
    Entry entry = new Entry();
    
    //declare and initialize list to hold entries
    public List<Entry> _entries = new List<Entry>();

    //method used to add new entries to journal. Displays random prompt, asks for user input, then adds to _entries list
    public void AddEntry()
    {
        Entry entry = new Entry();
        DateTime theCurrentTime = DateTime.Now;
        entry._dateText = theCurrentTime.ToShortDateString();
        entry._prompt = prompt.PromptGenerator();
        entry._entry = Console.ReadLine();
        _entries.Add(entry);
    }

    //method used to display entries
    public void DisplayEntries()
    {
        //iterate through each Entry instance in the list _entries
        foreach (Entry entry in _entries)
        {
            string line = entry.Convert();
            Console.WriteLine(line); 
        }
    }
    
    //method used to save a file. User enters file name.
    public void Save()
    {
        Console.WriteLine("What would you like to name the file? ");
        string fileName = Console.ReadLine();

        using (StreamWriter saveFile = new StreamWriter(fileName))
        {
            //iterate through each Entry instance in the list _entries
            foreach (Entry entry in _entries)
                {
                string line = entry.Convert();
                saveFile.WriteLine(line);
                }
        }
    }

    //method used to load a saved file
    public void LoadFile()
    {
        Console.WriteLine("What file would you like to load? ");
        string fileName = Console.ReadLine();

        if (File.Exists(fileName))
        {
        using (StreamReader sr = new StreamReader(fileName))
        {
            string theFile = sr.ReadToEnd();
            Console.WriteLine(theFile);
        }
        }
        else
        {
            //if file name entered does not match saved file, will present 'File not found'.
            Console.WriteLine("File not found. ");
        }
    }

    //Journal class constructor
    public Journal()
    {

    }

}