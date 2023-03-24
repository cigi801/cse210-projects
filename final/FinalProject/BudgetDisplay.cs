class BudgetDisplay
{

    protected string _budgetType;
    protected string _name;
    protected double _amount;

    protected List<Income> incomesList = new List<Income>();
    protected List<Savings> savingsList = new List<Savings>();
    protected List<Expense> expensesList = new List<Expense>();


    public BudgetDisplay()
    {
        
    }

    public BudgetDisplay(string name, double amount)
    {
        _name = name;
        _amount = amount;
    }

    public BudgetDisplay(string budgetType, string name, double amount)
    {
        _budgetType = budgetType;
        _name = name;
        _amount = amount;
    }


    public void DisplayBudget()
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
    }



}