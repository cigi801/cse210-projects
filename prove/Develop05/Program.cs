using System;

class Program
{
    static void Main(string[] args)
    {

        List<Goal> goals = new List<Goal>();

        int choice = 0;
        int goalType;

        //will loop back to this main menu as long as '6.Quit' is not selected
        while(choice != 6)
        {
        Console.WriteLine("Menu Options: ");
        Console.WriteLine("  1. Create New Goal ");
        Console.WriteLine("  2. List Goals ");
        Console.WriteLine("  3. Save Goals ");
        Console.WriteLine("  4. Load Goals ");
        Console.WriteLine("  5. Record Event ");
        Console.WriteLine("  6. Quit ");
        choice = int.Parse(Console.ReadLine());

        if (choice == 1)
        {
            
            int newChoice = 0;
            
            Console.WriteLine("The types of Goals are:");
            //One time achievment goal
            Console.WriteLine("  1. Simple Goal ");
            //Lifelong goal
            Console.WriteLine("  2. Eternal Goal" );
            //Goal series -- allows user to enter how many times they want to accomplish this goal
            Console.WriteLine("  3. Checklist Goal" );
            Console.WriteLine("Which type of goal would you like to create? ");
            goalType = int.Parse(Console.ReadLine());

            if(newChoice == 1)
            {
                Goal goal = new Goal();
                goal.GoalDetails();
                SimpleGoal simple = new SimpleGoal();
                goals.Add(simple);
            }

            
           
        }

        if (choice == 2)
        {
            
        }

        if (choice == 3)
        {
            
        }

        if (choice == 4)
        {
            
        }

        if (choice == 5)
        {
            
        }

        if (choice == 6)
        {
            Console.WriteLine("\nGoodbye\n");
        }

        else
        {
            Console.WriteLine("\nPlease select a valid option\n");
        }

        }
    }
}