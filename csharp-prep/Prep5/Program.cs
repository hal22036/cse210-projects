using System;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayWelcome()
        {
            Console.WriteLine($"Welcome to the Program!");
        }
        static string PromptUserName()
        {
            Console.Write($"What is your name? ");
            string name = Console.ReadLine();
            return name;
        }
        static int PromptUserNumber()
        {
            Console.Write($"What is your favorite number? ");
            int number = int.Parse(Console.ReadLine());
            return number;
        }
        static int SquareNumber(int x)
        {
            return x*x;            
        }
        static void DisplayResults(string userName, int favoriteNumber)
        {
            int sqNumber = SquareNumber(favoriteNumber);
            Console.WriteLine($"{userName}, Your favorite number squared is {sqNumber}");
        }

        DisplayWelcome();
        string userName = PromptUserName();
        int favoriteNumber = PromptUserNumber();
        DisplayResults(userName, favoriteNumber);
    }
}