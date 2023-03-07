using System;

class Program
{
    static void Main(string[] args)
    {
        string answer = "";
        int secondResponse = 0;
        while (!answer.Contains("5"))
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("   1. Start breathing activity");
            Console.WriteLine("   2. Start reflecting activity");
            Console.WriteLine("   3. Start listing activity");
            Console.WriteLine("   4. Start Take A Break activity");
            Console.WriteLine("   5. Quit");
            Console.Write("Select a choice from the menu: ");
            answer = Console.ReadLine();
            switch (answer)
            {
                case "1":
                    BreathingActivity breathing = new BreathingActivity("Breathing", "This activity will help you relax by walking you through breathin in and out slowly. Clear your mind and focus on your breathing.");
                    breathing.Welcome();
                    secondResponse = int.Parse(Console.ReadLine());
                    breathing.SetSeconds(secondResponse);
                    breathing.GetReady();                    
                    breathing.BreathingPrompt(secondResponse);
                    breathing.EndingMessage();
                    break;
                case "2":
                    ReflectionActivity reflection = new ReflectionActivity("Reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                    reflection.Welcome();
                    secondResponse = int.Parse(Console.ReadLine());
                    reflection.SetSeconds(secondResponse);
                    reflection.GetReady();
                    reflection.ReflectionPrompt(secondResponse);
                    reflection.EndingMessage();
                    break;
                case "3":
                    ListingActivity listing = new ListingActivity("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                    listing.Welcome();
                    secondResponse = int.Parse(Console.ReadLine());
                    listing.SetSeconds(secondResponse);
                    listing.GetReady();
                    listing.ListingPrompt(secondResponse);
                    listing.EndingMessage();
                    break;
                case "4":
                    BreakActivity takeABreak = new BreakActivity("Take A Break", "This activity will help you take a break in your day with short activities.");
                    takeABreak.Welcome();
                    secondResponse = int.Parse(Console.ReadLine());
                    takeABreak.SetSeconds(secondResponse);
                    takeABreak.GetReady();
                    takeABreak.BreakPrompt(secondResponse);
                    takeABreak.EndingMessage();
                    break;
                case "5":
                    System.Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("You entered an invalid option.");
                    break;
            }
        }
    }
}