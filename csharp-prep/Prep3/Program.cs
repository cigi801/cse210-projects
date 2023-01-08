using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 11);
        int guess = 0;
        int count = 0;

        while (guess != number)
        {
        Console.Write("What is your guess? ");
        guess = int.Parse(Console.ReadLine());
            if (guess < number)
            {
                Console.WriteLine("Guess higher" );
                count ++;
            }
            if (guess > number)
            {
                Console.WriteLine("Guess lower" );
                count ++;
            }
        }

        if(guess == number)
        {
            count ++;
            Console.Write($"You guessed it! Guess count = {count} ");
        }
    }
}