using System;

class Program
{
    static void Main(string[] args)

    {
        string answer;
        int guess = 0;
        Random randomGenerator = new Random();        
        int guesses = 1;

        do
        {
            guesses = 1;
            Console.WriteLine("I'm thinking of a number between 1 and 100!");
            
            int magicNumber = randomGenerator.Next(1,100);
            while (guess!=magicNumber)
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                if (guess> magicNumber)
            {
                Console.WriteLine("Lower");
                guesses ++;
            }
            else if (guess< magicNumber)
            {
                Console.WriteLine("Higher");
                guesses ++;
            }
            }
        Console.WriteLine($"You guessed it in {guesses} guesses! The magic number was {magicNumber}");
        Console.Write("Do you want to play again? ");
        answer = Console.ReadLine();
        }while (answer == "yes");
    }
}