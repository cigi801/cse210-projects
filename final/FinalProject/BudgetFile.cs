class BudgetFile : Budget
{


    public BudgetFile()
    {
        incomesList = new List<Income>();
        savingsList = new List<Savings>();
        expensesList = new List<Expense>();
    }
    
    public BudgetFile(string budgetType, string name, double amount) : base(budgetType, name, amount)
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


    public void SaveBudget(List<Income> incomesList, List<Expense> expensesList, List<Savings> savingsList)
    {
        Console.WriteLine("What would you like to name this file? (include .txt after your file name)");
        string fileName = Console.ReadLine();
        using StreamWriter writer = new StreamWriter(fileName);
        foreach(Income income in incomesList)
        {
            writer.WriteLine($"{income.GetBudgetLine()}");
        }
        foreach(Savings savings in savingsList)
        {
            writer.WriteLine($"{savings.GetBudgetLine()}");
        }
        foreach(Expense expense in expensesList)
        {
            writer.WriteLine($"{expense.GetBudgetLine()}");
        }

        Console.WriteLine("Saved File ");
    }

    public void LoadBudget()
    {
        Budget budget = new Budget();
        List<Income> incomesList = new List<Income>();
        List<Expense> expensesList = new List<Expense>();
        List<Savings> savingsList = new List<Savings>();
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
            double amount = double.Parse(parts[2]);
            
            if(budgetType == "Income")
            {
                incomesList.Add(new Income(budgetType, name, amount));
            }

            else if(budgetType == "Expense")
            {
                expensesList.Add(new Expense(budgetType, name, amount));
            }

            else
            {
               savingsList.Add(new Savings(budgetType, name, amount));
            }
            
            
            
        }

            Console.WriteLine("Your Income items ");
            foreach(Income income in incomesList)
            {
                Console.WriteLine($"{income.GetBudget()}");
            }

            Console.WriteLine("Your Expense items ");
            foreach(Expense expense in expensesList)
            {   
                Console.WriteLine($"{expense.GetBudget()}");
            }

            Console.WriteLine("Your Savings items ");
            // for(int i = 0; i < savingsList.Count(); i++)
            foreach(Savings savings in savingsList)
            {   
                Console.WriteLine($"{savings.GetBudget()}");
            }

      
        }
        else
        {
            Console.WriteLine("File not found. ");
        }
       
    }

}