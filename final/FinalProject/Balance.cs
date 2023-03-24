class Balance : Budget
{
    protected double _totalIncome;
    protected double _totalExpenses;
    protected double _totalSavings;

    protected double _balance;

    protected List<Income> incomesList = new List<Income>();
    protected List<Savings> savingsList = new List<Savings>();
    protected List<Expense> expensesList = new List<Expense>();

    public Balance()
    {

    }
    public Balance(string budgetType, string name, double amount) : base(budgetType, name, amount)
    {

    }

    public Balance(double totalIncome, double totalExpenses, double totalSavings)
    {
        _totalIncome = totalIncome;
        _totalExpenses = totalExpenses;
        _totalSavings = totalSavings;
    }

    public void GetBalance()
    {
        double totalIncome = 0;
        double totalExpenses = 0;
        double totalSavings = 0;
        Console.WriteLine("Income: ");
        foreach(Income income in incomesList)
            {
               totalIncome += income.GetAmount();
            }
            Console.WriteLine(_totalIncome);
        Console.WriteLine("Expenses: ");
        foreach(Expense expense in expensesList)
            {
                totalExpenses += expense.GetAmount();
            }
            Console.WriteLine(_totalExpenses);
        Console.WriteLine("Savings: ");
        foreach(Savings savings in savingsList)
            {
              totalSavings += savings.GetAmount();
              Console.WriteLine(_totalSavings);
            }
    }



}