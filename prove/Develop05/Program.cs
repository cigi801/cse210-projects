using System;
using System.IO; 
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        
        List<Goal> goals = new List<Goal>();
        List<Goal> points = new List<Goal>();
        int choice = 0;
        int goalType;
        
        //will loop back to this main menu as long as '6.Quit' is not selected
        while(choice != 6)
        {
        
        Console.WriteLine("Menu Options: ");
        Console.WriteLine("  1. Create New Goal ");
        Console.WriteLine("  2. Display Goals ");
        Console.WriteLine("  3. Save Goals ");
        Console.WriteLine("  4. Load Goals ");
        Console.WriteLine("  5. Record Event ");
        Console.WriteLine("  6. Quit ");
        choice = int.Parse(Console.ReadLine());

        if (choice == 1)
        {   
            Console.WriteLine("The types of Goals are:");
            //One time achievment goal
            Console.WriteLine("  1. Simple Goal ");
            //Lifelong goal
            Console.WriteLine("  2. Eternal Goal" );
            //Checklist -- allows user to enter how many times they want to accomplish this goal
            Console.WriteLine("  3. Checklist Goal" );
            
            goalType = int.Parse(Console.ReadLine());

            Console.WriteLine("What is the name of your goal? ");
            //stores goal name in variable
            string name = Console.ReadLine();
            Console.WriteLine("What is a short description of it? ");
            //stores goal descrtipion in variable
            string description = Console.ReadLine();
            Console.WriteLine("What is the amount of points associated with this goal? ");
            //stores point value in variable
            int point = int.Parse(Console.ReadLine());
            
            //Goal type 1 - Simple Goal
            if(goalType == 1)
            {
                bool completed = false;
                SimpleGoal simple = new SimpleGoal(name, description, point, completed);
                goals.Add(simple);
            }

            //Goal type 2 - Eternal Goal
            if(goalType == 2)
            {
                EternalGoal eternal = new EternalGoal(name, description, point);
                goals.Add(eternal);
            }

            //Goal type 3 - Checklist Goal
            if(goalType == 3)
            {
                Console.WriteLine("How many times does this goal need to be accomplished for a bonus? ");
                int numberOfTimes = int.Parse(Console.ReadLine());
                Console.WriteLine("What is the bonus for accomplishing this goal? ");
                int bonus = int.Parse(Console.ReadLine());
                int completed = 0;
                ChecklistGoal checklist = new ChecklistGoal(name, description, point, bonus, numberOfTimes, completed);
                goals.Add(checklist);
            }
        }

        //choice 2, display goals
        else if (choice == 2)
        {
            foreach(Goal line in goals) 
            {
                line.DisplayGoal();
            } 
        }

        //Choice 3, save file
        else if (choice == 3)
        {
            Console.WriteLine("What would you like to name the file to save your goals to? ");
            string fileName = Console.ReadLine();
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                foreach (Goal goal in goals)
                    {
                        writer.WriteLine(goal.ToString());
                    }
            }
        }
        

        //Choice 4, load file
        else if (choice == 4)
        {
            Console.WriteLine("What is the name of the file?");
            string fileName = Console.ReadLine();
            if (File.Exists(fileName))
            {
                using (StreamReader sr = new StreamReader(fileName))
                {
                    string theFile = sr.ReadToEnd();
                    Console.WriteLine(theFile);
                }
            }
            else
            {
                //if file name entered does not match saved file, will present 'File not found'.
                Console.WriteLine("File not found. ");
            }
        }

        else if (choice == 5)
        {
           
        }

        else if (choice == 6)
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