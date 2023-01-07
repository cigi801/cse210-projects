using System;

class Program
{
    static void Main(string[] args)
    {
        
        Console.Write("What is your grade percentage? ");
        string percentageInput = Console.ReadLine();

        int percentage = int.Parse(percentageInput);
        string letter = "A";
        string sign = "";

        if (percentage >= 90)
        {
            letter = "A";
        }
        else if (percentage >= 80)
        {
            letter = "B";
        }
        else if (percentage >= 70)
        {
            letter = "C";
        }
        else if (percentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        


        if (percentage > 59 && percentage % 10 >= 7)
        {
            sign = "+";
        }
        else if (percentage > 59 && percentage % 10 < 3)
        {
            sign = "-";
        }
        else
        {
            sign = "";
        }

        Console.WriteLine($"Your grade: {letter}{sign} ");


        if (percentage >= 70)
        {
            Console.WriteLine("Congratulations! You have passed the course. ");
        }
        else
        {
            Console.WriteLine("I'm sorry, you did not pass the course. ");
        }
    }
}