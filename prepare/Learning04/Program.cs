using System;

class Program
{
    static void Main(string[] args)
    {
        //Creating new Assignment and assigning values
        Assignment assignment1 = new Assignment("Greg", "C# Lesson");
        //Printing assignment 1 using GetSummary
        Console.WriteLine(assignment1.GetSummary());

        //Creating new MathAssignment and assigning values
        MathAssignment math1 = new MathAssignment("Henry", "Trigonometry", "Circle", "1-5");
        Console.WriteLine(math1.GetSummary());
        Console.WriteLine(math1.GetHomeworkList());

        //Creating new WritingAssignment and assigning values
        WritingAssignment writing1 = new WritingAssignment("Smeagol", "Programming", "C# Tutorial");
        Console.WriteLine(writing1.GetSummary());
        Console.WriteLine(writing1.GetWritingInformation());
    }
}