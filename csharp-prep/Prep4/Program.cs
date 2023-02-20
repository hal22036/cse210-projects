using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int number;
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
            
        do
        {
            {
                Console.Write("Enter number: ");
                string userInput = Console.ReadLine();
                number = int.Parse(userInput);
                numbers.Add(number);
            }
        } while (number != 0);        

        if (number==0)
            {
                int total = numbers.Sum();
                Console.WriteLine($"The sum is: {total}");
                float avg = ((float)total / (numbers.Count -1));
                Console.WriteLine($"The average is: {avg}");
                float largest = numbers.Max();
                Console.WriteLine($"The largest number is: {largest}");
            }
    }
}