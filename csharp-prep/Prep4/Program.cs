using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        
        List<int> numbers = new List<int>();
        int numberInput = -1;
        

        while (numberInput != 0)
        {
            Console.WriteLine("Enter a number, type 0 when finished ");
            numberInput = int.Parse(Console.ReadLine());

            if (numberInput != 0)
            {
                numbers.Add(numberInput);
            }
        }

        float sum = 0;

        foreach (int number in numbers)
        {
            sum += number;
        }
        
        Console.WriteLine($"The sum of these numbers is: {sum} ");
        
        float average = sum / numbers.Count;
        Console.WriteLine($"The average is: {average} ");

        
        numbers.Sort();
        
        float max = numbers[numbers.Count -1];
        Console.WriteLine($"The max number is: {max} ");
        Console.WriteLine("The sorted list is " + string.Join(",", numbers));
        
    }
}