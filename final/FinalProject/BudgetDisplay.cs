class BudgetDisplay : Budget
{


    public BudgetDisplay()
    {
        incomesList = new List<Income>();
        savingsList = new List<Savings>();
        expensesList = new List<Expense>();
    }


    public void DisplayBudget(List<Income> incomesList, List<Expense> expensesList, List<Savings> savingsList)
    {
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
            foreach(Savings savings in savingsList)
            {   
                Console.WriteLine($"{savings.GetBudget()}");
            }
    }


}