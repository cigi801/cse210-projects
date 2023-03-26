//Parent class Budget

class Budget
{
    protected string _budgetType;
    protected string _name;
    protected double _amount;

    protected List<Income> _incomesList = new List<Income>();
    protected List<Savings> _savingsList = new List<Savings>();
    protected List<Expense> _expensesList = new List<Expense>();



    public Budget()
    {

    }

    public List<Income> incomesList
    {
        get{ return _incomesList; }
        set{ _incomesList = value; }
    }

    public List<Expense> expensesList
    {
        get{ return _expensesList; }
        set{ _expensesList = value; }
    }

    public List<Savings> savingsList
    {
        get{ return _savingsList; }
        set{ _savingsList = value; }
    }




    public Budget(string budgetType, string name, double amount)
    {
        _budgetType = budgetType;
        _name = name;
        _amount = amount;
    }

    public Budget(double amount)
    {
        _amount = amount;
    }



    public virtual string GetBudget()
    {
        return $"{_name}: {_amount}";
    }

    public virtual string GetBudgetLine()
    {
        string budget = $"{_budgetType},{_name},{_amount}";
        return budget;
    }

    public virtual string GetBudgetType()
    {
        return _budgetType;
    }

    public virtual double GetAmount()
    {
        return _amount;
    }

    public virtual string GetName()
    {
        return _name;
    }

    public virtual void SetAmount(double amount)
    {
        _amount = amount;
    }



    
    public void AddIncome()
    {
        string budgetType = "Income";
        Console.WriteLine("Adding Income ");
        Console.WriteLine("What would you like to name this income? ");
        string name = Console.ReadLine().ToUpper();
        Console.WriteLine("What is the monthly amount you'll be receiving for this type of income? ");
        double amount = double.Parse(Console.ReadLine());
        incomesList.Add(new Income(budgetType, name, amount));
        Console.WriteLine($"{name} added as an Income category on your Budget! ");
    }

    public void AddExpense()
    {
        string budgetType = "Expense";
        Console.WriteLine("Adding Expense ");
        Console.WriteLine("What would you like to name this expense? ");
        string name = Console.ReadLine().ToUpper();
        Console.WriteLine("What is the monthly amount this expense will cost? ");
        double amount = double.Parse(Console.ReadLine());
        expensesList.Add(new Expense(budgetType, name, amount));
        Console.WriteLine($"{name} added as an Expense category on your Budget! ");
    }

    public void AddSavings()
    {
        string budgetType = "Savings";
        Console.WriteLine("Adding Savings ");
        Console.WriteLine("What would you like to name this Savings category? ");
        string name = Console.ReadLine().ToUpper();   
        Console.WriteLine("What is the monthly amount you'd like to allocate for this Savings category? ");
        double amount = double.Parse(Console.ReadLine());
        savingsList.Add(new Savings(budgetType, name, amount));
        Console.WriteLine($"{name} added as a Savings category on your Budget! ");
    }

    public void EditBudget()
    {
        
        Console.WriteLine("Your Income items ");
            for(int i = 0; i < incomesList.Count(); i++)
            {
                Console.WriteLine($"{incomesList[i].GetBudget()}");
            }

            Console.WriteLine("Your Expense items ");
            for(int i = 0; i < expensesList.Count(); i++)
            {   
                Console.WriteLine($"{expensesList[i].GetBudget()}");
            }

            Console.WriteLine("Your Savings items ");
            for(int i = 0; i < savingsList.Count(); i++)
            {   
                Console.WriteLine($"{savingsList[i].GetBudget()}");
            }

            Console.WriteLine("What is the name of the budget item you would like to edit? ");

    }


}