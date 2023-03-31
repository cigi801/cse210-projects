using System;
using System.IO;
using System.Collections.Generic;


class Program
{

    
    static void Main(string[] args)
    {

        Budget budget = new Budget();
        List<Budget> budgets = new List<Budget>(); 

    while(true)
    {
        
        Console.WriteLine("Welcome to your budget");
        Console.WriteLine("What would you like to do: ");
        Console.WriteLine("1. Add Income");
        Console.WriteLine("2. Add Expense");
        Console.WriteLine("3. Add Savings");
        Console.WriteLine("4. Add Charity");
        Console.WriteLine("5. Edit Budget");
        Console.WriteLine("6. Save Budget");
        Console.WriteLine("7. Load Budget");
        Console.WriteLine("8. View Budget List");
        Console.WriteLine("9. Exit");

        int choice = int.Parse(Console.ReadLine());

   
        //Add Income
        if (choice == 1)
        {
            budget = new Income();
            Console.WriteLine("What would you like to name this Income? ");
            string name = Console.ReadLine().ToUpper();
            budget.SetName(name);
            Console.WriteLine("What is the monthly amount of this Income? ");
            double amount = double.Parse(Console.ReadLine());
            budget.SetAmount(amount);
            budgets.Add(budget);
        }

        //Add Expense
        else if (choice == 2)
        {
            budget = new Expense();
            Console.WriteLine("What would you like to name this Expense? ");
            string name = Console.ReadLine().ToUpper();
            budget.SetName(name);
            Console.WriteLine("What is the monthly amount this Expense will cost? ");
            double amount = double.Parse(Console.ReadLine());
            budget.SetAmount(amount);
            budgets.Add(budget);
        }

        //Add Savings
        else if (choice == 3)
        {
            budget = new Savings();
            Console.WriteLine("What would you like to name this Savings category? ");
            string name = Console.ReadLine().ToUpper();  
            budget.SetName(name); 
            Console.WriteLine("What is the monthly amount you'd like to allocate for this Savings category? ");
            double amount = double.Parse(Console.ReadLine());
            budget.SetAmount(amount);
            budgets.Add(budget);
        }

        else if (choice == 4)
        {
            budget = new Charity();
            Console.WriteLine("What would you like to name this Charity category? ");
            string name = Console.ReadLine().ToUpper();
            budget.SetName(name);
            Console.WriteLine("What is the monthly amount you'd like to allocate for this Charity category? ");
            double amount = double.Parse(Console.ReadLine());
            budget.SetAmount(amount);
            budgets.Add(budget);
        }

    
        //Edit Budget 
        else if (choice == 5)
        {
            foreach (Budget budgetItem in budgets)
            {
                Console.WriteLine($"{budgetItem.GetName()}: {budgetItem.GetAmount()}");
            }

            Console.WriteLine("What is the name of the budget item you would like to edit? ");
            string userInput = Console.ReadLine().ToUpper();
            int budgetIndex = -1;
            for(int i = 0; i < budgets.Count; i++)
            {
                if(budgets[i].GetName().ToString() == userInput.ToUpper())
                {
                Console.WriteLine("What would you like to change the monthly amount to? ");
                double budgetAmountChanged =double.Parse(Console.ReadLine());
                budgets[i].SetAmount(budgetAmountChanged);
                Console.WriteLine("Updated budget amount! ");
                budgetIndex = i;
                
                }

                else//if(budgetIndex == -1)
                {
                    Console.WriteLine("Budget item not found. ");
                }

            }
        }

        //Save Budget
        else if (choice == 6)
        {
            Console.WriteLine("What would you like to name this file? (include .txt after your file name)");
            string fileName = Console.ReadLine();
            using StreamWriter writer = new StreamWriter(fileName);
            foreach(Budget budgetItem in budgets)
            {
                string type = budgetItem.GetType().Name;
                string name = budgetItem.GetName();
                double amount = budgetItem.GetAmount();
                writer.WriteLine($"{type},{name},{amount}");
            }
            Console.WriteLine("Saved File ");
        }


        //Load Budget
        else if (choice == 7)
        {
            Console.WriteLine("What file would you like to load? ");
        string fileName = Console.ReadLine();


        if(File.Exists(fileName))
        {
        budgets.Clear();
        string[] lines = System.IO.File.ReadAllLines(fileName);
        foreach(string line in lines)
        {
            string[] parts = line.Split(",");
            string type = parts[0];
            string name = parts[1];
            double amount = double.Parse(parts[2]);

            Budget budgetItem;
            switch(type)
            {
            case "Income":
            budgetItem = new Income();
            break;
            case "Expense":
            budgetItem = new Expense();
            break;
            case "Savings":
            budgetItem = new Savings();
            break;
            case "Charity":
            budgetItem = new Charity();
            break;
            default: 
            Console.WriteLine("issue with budget type, skipping line");
            continue;
            }
            budgetItem.SetName(name);
            budgetItem.SetAmount(amount);
            budgets.Add(budgetItem);
        }
        Console.WriteLine("File Loaded. ");
        }
        else
        {
            Console.WriteLine("File not found. ");
        }
        }

        //View budget list
        else if (choice == 8)
        {
            foreach(Budget budgetItem in budgets)
            {
                if(budgetItem is Income)
                {
                    Console.WriteLine($"Income: {budgetItem.GetName()}: {budgetItem.GetAmount()}");
                }
                else if (budgetItem is Expense)
                {
                    Console.WriteLine($"Expense: {budgetItem.GetName()}: {budgetItem.GetAmount()}");
                }
                else if (budgetItem is Savings)
                {
                Console.WriteLine($"Savings: {budgetItem.GetName()}: {budgetItem.GetAmount()}");
                }
                else if (budgetItem is Charity)
                {
                    Console.WriteLine($"Charity: {budgetItem.GetName()}: {budgetItem.GetAmount()}");
                }
            }
        }

            else if (choice == 9)
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


