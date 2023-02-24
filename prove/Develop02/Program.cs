using System;

class Program
{
    static void Main(string[] args)
    {
        int response = 0;
        Journal journal = new Journal();
        do
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Journal Program!");
            Console.WriteLine($"Please select one of the following choices:");
            Console.WriteLine($"1. Write Journal");
            Console.WriteLine($"2. Scripture Study");
            Console.WriteLine($"3. Display");
            Console.WriteLine($"4. Load File");
            Console.WriteLine($"5. Save File");
            Console.WriteLine($"6. Quit");
            Console.Write($"What would you like to do? ");
            response = int.Parse(Console.ReadLine());

            if (response == 1)
            {
                journal.WriteEntry();
            }
            else if (response == 2)
            {
                journal.ScriptureStudy();
            }
            else if (response == 3)
            {
                journal.DisplayJournal();
            }
            else if (response == 4)
            {
                journal.LoadJournal();
            }
            else if (response == 5)
            {
                journal.SaveJournal();
            }
            else if (response == 6)
            {
                break;
            }
        }
        while (response != 6);
        { }
    }
}