class BudgetFile
{
    protected string _budgetType;
    protected string _name;
    protected double _amount;
    protected List<Income> incomesList = new List<Income>();
    protected List<Savings> savingsList = new List<Savings>();
    protected List<Expense> expensesList = new List<Expense>();

    public BudgetFile()
    {

    }
    
    public BudgetFile(string budgetType, string name, double amount)
    {
        _budgetType = budgetType;
        _name = name;
        _amount = amount;
    }

    public BudgetFile(string name, double amount)
    {
        _name = name;
        _amount = amount;
    }


    public void SaveBudget()
    {
        Console.WriteLine("What would you like to name this file? (include .txt after your file name)");
        string fileName = Console.ReadLine();
        using StreamWriter writer = new StreamWriter(fileName);
        foreach(var category in incomesList)
        {
            writer.WriteLine($"{_budgetType},{_name},{_amount}");
        }
        foreach(var category in savingsList)
        {
            writer.WriteLine($"{_budgetType},{_name},{_amount}");
        }
        foreach(var category in expensesList)
        {
            writer.WriteLine($"{_budgetType},{_name},{_amount}");
        }

        Console.WriteLine("Saved File ");
    }

    public void LoadBudget()
    {
        Console.WriteLine("What file would you like to load? ");
        string fileName = Console.ReadLine();

        if(File.Exists(fileName))
        {
        string[] lines = System.IO.File.ReadAllLines(fileName);
        
        foreach (string line in lines)
        {
            string[] parts = line.Split(",");
            string budgetType = parts[0];
            string name = parts[1];
            string amount = parts[2];
        }
        Console.WriteLine(lines);
        }
        else
        {
            Console.WriteLine("File not found. ");
        }

    }

}