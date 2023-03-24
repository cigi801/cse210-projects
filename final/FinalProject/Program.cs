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

        

        //Edit Budget
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
            budgetFile.SaveBudget();
        }

        //Load Budget
        else if (choice == 6)
        {
            budgetFile.LoadBudget();
        }

        //View budget analysis
        else if (choice == 7)
        {
            budgetDisplay.DisplayBudget();

            Console.WriteLine("What would you like to do? ");
            Console.WriteLine("1. View Budget Balance\n2. View Percentage Breakdown\n3. View Yearly Analysis ");

            int analysisChoice = int.Parse(Console.ReadLine());

            if (analysisChoice == 1)
            {
                balance.GetBalance();
                // Console.WriteLine($"Total Monthly Income: {budgets.Where(b => b.GetBudgetType() == "Income").Sum(b => b.GetAmount())}");
                // Console.WriteLine($"Total Monthly Expenses: {budgets.Where(b => b.GetBudgetType() == "Expense").Sum(b => b.GetAmount())}");
                // Console.WriteLine($"Total Monthly Savings: {budgets.Where(b => b.GetBudgetType() == "Savings").Sum(b => b.GetAmount())}");
                
            }

            else if (analysisChoice == 2)
            {

            }

            else if (analysisChoice == 3)
            {

            }

            else
            {
                Console.WriteLine("");
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