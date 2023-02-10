using System.Text;

class Scripture
{
    private string _scripture;

    private List<string> hideWords;

    private List<int> indexes;

    //private List<int> shuffled;

    //Create new Reference object
    Reference reference = new Reference();

    //Scripture constructor 
    public Scripture()
    {
       hideWords =  new List<string>();
       indexes = new List<int>();
       // shuffled = new List<int>();
    }

    //Getter method will return the scripture string
    public string GetScripture()
    {
        return _scripture;
    }

    //Setter method will allow variable to be assigned a value
    public void SetScripture(string value)
    {
        _scripture = value;
    }

    //method to find random word and add to list
    public void HideWord()
    {
        string[] words = _scripture.Split(' ');
        int index = -1;

        /*
        Possible testing
        Random random = new Random();
        shuffled = values.OrderBy(_ => random.Next()).ToList();

        int listLength = words.Count;
        Random random = new Random();
        int rand = random.Next(ListLength);
        Console.WriteLine(random);
        for (int i = 0, int i > 4, i++)

        foreach(string word in words)
        {

        }

        */
       
        while(!indexes.Contains(index))
        {
            // Reset the random index nunber
            Random random = new Random();
            //Store the random index number in a variable
            index = random.Next(words.Length);
       
            // check if word index has already been added to list
            if(!indexes.Contains(index))
            {
                string hiddenWord = words[index];
                
                hideWords.Add(hiddenWord);
            }
            // need to find out how to make sure random chooses a new index every time (not check duplicates)
            // add the index to the index list
            indexes.Add(index);
            
        }
        
    }

    public bool Finished()
    {
        string[] words = _scripture.Split(' ');
        return hideWords.Count == words.Length;
    }

    // display scripture and hidden words
    public void DisplayScripture()
    {
        
        string[] words = _scripture.Split(' ');
        foreach (string word in words)
        {
            if (hideWords.Contains(word))
            {
                StringBuilder s = new StringBuilder(word);
            foreach(char letter in word)
            {
                char us = '_';
                s.Replace(letter, us);  
            }  
                Console.Write($"{s.ToString()} ");
            //hideWords.Add(hiddenWord);
            }
            else
            {
                Console.Write($"{word} ");
            }

        }

        Console.WriteLine();
    } 
        
}



