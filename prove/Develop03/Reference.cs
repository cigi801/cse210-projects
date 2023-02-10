class Reference
{
    private string reference;
    private string _book;
    private string _chapter;
    private string _verse;
    private string _endVerse;

    //Reference Constructor
    public Reference()
    {
    
    }

    //Getter method will return book, chapter and verse
    public string GetReference()
    {
       string reference = $"{_book} {_chapter}:{_verse}";
       return reference;
        
    }

    //Setter method sets values of public variables and allows you to assign values to variables
    public void SetSingleVerses(string book, string chapter, string verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }


    public void DisplayReference()
    {
        Console.WriteLine($"{_book} {_chapter}:{_verse}");

    }

   


}