using System;
using System.IO; 
using System.Collections.Generic;

public class Program
{
    static void Main(string[] args)
    {
        //Initializing 'journal' and 'entry' class instances
        Journal journal = new Journal();
        Entry entry = new Entry();

        char choice = '0';
        //menu repeats if 'choosing' is false
        bool choosing = false;

        while (!choosing)
        {
            Console.WriteLine();
            Console.WriteLine("Welcome to the Journal Program!");
            Console.WriteLine("Please select one of the following choices: ");
            Console.WriteLine("1. Add a new Journal Entry ");
            Console.WriteLine("2. Display ");
            Console.WriteLine("3. Load ");
            Console.WriteLine("4. Save ");
            Console.WriteLine("5. Quit ");
            Console.WriteLine("What would you like to do? ");
            choice = Console.ReadKey().KeyChar;
            
            if (choice == '1')
            {
                Console.WriteLine();
                journal.AddEntry();
                choosing = false;
            }
            else if (choice == '2')
            {
                Console.WriteLine();
                journal.DisplayEntries();
                choosing = false;
            }
            else if (choice == '3')
            {
                Console.WriteLine();
                journal.LoadFile();
                choosing = false;
            }
            else if (choice == '4')
            {
                Console.WriteLine();
                journal.Save();
                choosing = false;
            }
            else if (choice == '5')
            {
                Console.WriteLine();
                Console.WriteLine("Goodbye. ");
                //program quits if 'choosing' is true
                choosing = true;
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Please enter a valid number option. ");
                choosing = false;
            }
        }
    }
}