using System;
using System.Collections.Generic;
using System.Linq;


class Program
{
    static void Main(string[] args)
    {

        int choice = 0;
        while (choice != 4)
        {
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflecting Activity");
            Console.WriteLine("3. Start Listing Activity");
            Console.WriteLine("4. Quit");
            Console.WriteLine("Select a choice from the menu: ");

            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                BreathingActivity breathing = new BreathingActivity();
                breathing.StartBreathingActivity();
            }

            if (choice == 2)
            {
                ReflectionActivity reflection = new ReflectionActivity();
                reflection.StartReflectionActivity();
            }

            if (choice == 3)
            {
                ListingActivity listing = new ListingActivity();
                listing.StartListingActivity();
            }

            if (choice == 4)
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