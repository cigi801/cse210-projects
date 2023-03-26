
class Balance : Budget
{
    protected double _totalIncome;
    protected double _totalExpenses;
    protected double _totalSavings;

    public Balance()
    {

    }

    public Balance(double totalIncome, double totalExpenses, double totalSavings)
    {
        _totalIncome = totalIncome;
        _totalExpenses = totalExpenses;
        _totalSavings = totalSavings;
    }

    public override double GetAmount()
    {
        return _amount;
    }

    public void GetBalance(List<Income> incomesList, List<Expense> expensesList, List<Savings> savingsList)
    {
        
        double totalIncome = 0;
        double totalExpenses = 0;
        double totalSavings = 0;
        Console.WriteLine("Income: ");
        foreach(var income in incomesList)
        {
            // totalIncome += income; 
            Console.WriteLine(income.GetAmount());
        }
        // Console.WriteLine(totalIncome);

        Console.WriteLine("Expenses: ");
        foreach(var expense in expensesList)
        {
            // totalExpenses += expense;
            Console.WriteLine(expense.GetAmount());
        }


        Console.WriteLine(totalExpenses);
        Console.WriteLine("Savings: ");
        foreach(var savings in savingsList)
            {
            Console.WriteLine(savings.GetAmount());
            }

    }



}