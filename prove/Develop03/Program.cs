using System;
using System.Collections.Generic;
using System.Linq;


class Program
{
    static void Main(string[] args)
    {   
        //Create new Reference object
        Reference reference = new Reference();
        reference.SetSingleVerses("Matthew", "6", "21");

        // Create new Scripture object
        Scripture scripture = new Scripture();
        // Call setter to assign value to variable
        scripture.SetScripture("For where your treasure is, there will your heart be also.");
        //scripture.SetScripture("This is a test.");

        Console.Clear();

        reference.DisplayReference();
        scripture.DisplayScripture();

        while (true)
        {   
            Console.WriteLine("\nPress enter to continue or type 'quit' to finish: "); 
            string enterInput = Console.ReadLine();
            

            if (enterInput.ToLower() == "quit")
            {
                Console.WriteLine("goodbye.");
            }
            else
            {
                Console.Clear();
                reference.DisplayReference();
                scripture.HideWord();
                scripture.DisplayScripture();
                if (scripture.Finished())
                {
                    Console.WriteLine("Congratulations, you have memorized the scripture!");
                }
            }
        }


    }
}