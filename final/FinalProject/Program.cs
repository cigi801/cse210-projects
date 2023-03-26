using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;


class Program
{

    
    static void Main(string[] args)
    {
        Budget budget = new Budget();
        BudgetDisplay budgetDisplay = new BudgetDisplay();
        BudgetFile budgetFile = new BudgetFile();
        Balance balance = new Balance();
        Percentage percentage = new Percentage();
        
        
        List<Income> incomesList = new List<Income>();
        List<Expense> expensesList = new List<Expense>();
        List<Savings> savingsList = new List<Savings>();

        

        while(true)
        {
        
        Console.WriteLine("Welcome to your budget");
        Console.WriteLine("What would you like to do: ");
        Console.WriteLine("1. Add Income");
        Console.WriteLine("2. Add Expense");
        Console.WriteLine("3. Add Savings");
        Console.WriteLine("4. Edit Budget");
        Console.WriteLine("5. Save Budget");
        Console.WriteLine("6. Load Budget");
        Console.WriteLine("7. View Budget Analysis");
        Console.WriteLine("8. Exit");

        int choice = int.Parse(Console.ReadLine());

   
        //Add Income
        if (choice == 1)
        {
            budget.AddIncome();
        }

        //Add Expense
        else if (choice == 2)
        {
            budget.AddExpense();
        }

        //Add Savings
        else if (choice == 3)
        {
            budget.AddSavings();
        }

        

        //Edit Budget (still working on this, need to move edit code below to Budget.EditBudget())
        //I will change userInput to be budget type instead of int
        else if (choice == 4)
        {
            budget.EditBudget();
            

            
            // Console.WriteLine("Please enter the number of the budget item you'd like to update ");
            // int userInput = int.Parse(Console.ReadLine());
            // int budgetIndex = userInput - 1;
            // Console.WriteLine("What would you like to change the monthly amount to? ");
            // int budgetAmountChanged =int.Parse(Console.ReadLine());
            
            // change amount
            //budgets[budgetIndex].SetAmount(budgetAmoutChanged);
            // = new Budget(budgetAmountChanged);
            

            //Console.WriteLine("Updated budgeted amount! ");

            // Console.WriteLine("Your budget items: ");
            // for(int i = 0; i < budgets.Count(); i++)
            // {
            //     Console.WriteLine($"{i + 1}. {budgets[i].GetBudget()}");
            // }

            
        }

        //Save Budget
        else if (choice == 5)
        {
            budgetFile.SaveBudget(budget.incomesList, budget.expensesList, budget.savingsList);
        }

        //Load Budget
        //Still working on this, load budget saves new list in BudgetFile instead of Budget. The other classes use the list from Budget
        else if (choice == 6)
        {
            budgetFile.LoadBudget();
            
        }

        //View budget analysis
        else if (choice == 7)
        {
            //This is only working with newly added budget items. Will not work with loaded file
            budgetDisplay.DisplayBudget(budget.incomesList, budget.expensesList, budget.savingsList);

            Console.WriteLine("What would you like to do? ");
            Console.WriteLine("1. View Budget Balance\n2. View Percentage Breakdown\n");

            int analysisChoice = int.Parse(Console.ReadLine());

            //Balances
            //Will show the total amount income, expenses and savings
            //Still working on this, need to figure out how to get amount from lists and add them togehter
            if (analysisChoice == 1)
            {

                balance.GetBalance(budget.incomesList, budget.expensesList, budget.savingsList);
                // Console.WriteLine($"Total Monthly Income: {budgets.Where(b => b.GetBudgetType() == "Income").Sum(b => b.GetAmount())}");
                // Console.WriteLine($"Total Monthly Expenses: {budgets.Where(b => b.GetBudgetType() == "Expense").Sum(b => b.GetAmount())}");
                // Console.WriteLine($"Total Monthly Savings: {budgets.Where(b => b.GetBudgetType() == "Savings").Sum(b => b.GetAmount())}");
                
            }

            //Percentages
            //Will show the percentages of each budget type
            else if (analysisChoice == 2)
            {
                
            }

            else
            {
                Console.WriteLine("Please enter a valid option. ");
            }
        
        }

        else if (choice == 8)
        {
            Console.WriteLine("Goodbye ");
        }

        else
        {
            Console.WriteLine("Please enter a valid option. ");
        }

        }


    }
}