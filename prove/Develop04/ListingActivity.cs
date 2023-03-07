using System;
using System.Diagnostics;
public class ListingActivity : Activity
{
    private List<string> _listingQuestions = LoadFile("ListingPrompt.txt");
    private List<string> _listingAnswers = new List<string>();
    private int _listNumber;
    private Random random = new Random();
    public ListingActivity(string activityType, string activityDescription) : base(activityType, activityDescription){}
    public void ListAnswers(int number)
    {
        _listNumber = 1;
        GetStopwatch().Start();
        do
        {
            Console.Write($"{_listNumber++}. ");
            string response = Console.ReadLine();
            _listingAnswers.Add(response);
        } while (GetStopwatch().ElapsedMilliseconds <= number * 1000);

    }
    public void ListingPrompt(int number)
    {
        Console.WriteLine(_listingQuestions[random.Next(_listingQuestions.Count())]);
        CountDown(10);
        ListAnswers(number);
        Console.WriteLine($"{_listNumber - 1} Items were listed.");
    }
}