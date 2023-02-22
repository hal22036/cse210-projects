using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");

        static void DisplayMenu()
        {            
            Console.WriteLine($"Please select one of the following choices:");        
            Console.WriteLine($"1. Write");
            Console.WriteLine($"2. Display");
            Console.WriteLine($"3. Load");
            Console.WriteLine($"4. Save");
            Console.WriteLine($"5. Quit");
            Console.Write($"What would you like to do? ");
            int response = int.Parse(Console.ReadLine());
                        
            Journal journal = new Journal();
            if (response==1)
            {
                journal.WriteEntry();     
                DisplayMenu();                 
            }
            else if (response==2)
            {                    
                journal.DisplayJournal();
                // DisplayMenu();
            }
            else if (response==3)
            {
                journal.LoadJournal();
                DisplayMenu();
            }
            else if (response==4)
            {
                journal.SaveJournal();
                DisplayMenu();
            }
            else if (response==5)
            {
                Console.WriteLine("Thank you for your checking out the Journal Program!");
            }
            else 
            {                    
                Console.WriteLine($"You entered an invalid response, try again.");
                DisplayMenu();
            }
            
        }
        DisplayMenu();
    }
}