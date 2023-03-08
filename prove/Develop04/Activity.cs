using System;
using System.Threading;
using System.Diagnostics;
public class Activity
{
    private string _activityType, _activityDescription;
    private int _seconds;
    private Stopwatch _startTime = new Stopwatch();
    private Stopwatch _stopwatch = new Stopwatch();
    protected Random random = new Random();
    public Activity(string activityType, string activityDescription)
    {
        _activityType = activityType;
        _activityDescription = activityDescription;
        _startTime.Start();
    }
    public void Welcome()
    {
        Console.WriteLine($"\n\nWelcome to the {_activityType} activity.");
        Console.WriteLine($"\n\n{_activityDescription}");
        Console.Write("\n\nHow long in seconds, would you like for your session? (each prompt is 20 seconds) ");
    }
    public void GetReady()
    {
        Console.Clear();
        Console.WriteLine($"\n\nGet Ready...");
        Pause(2);
        Console.Clear();
    }
    public void EndingMessage()
    {
        double timeElapsed = _startTime.ElapsedMilliseconds;
        double timeSeconds = Math.Round(timeElapsed / 1000);
        Console.WriteLine("\n\nGood Job!");
        Pause(2);
        Console.WriteLine($"You have completed the {_activityType} activity in {timeSeconds} seconds.");
        Pause(5);
    }
    public void Pause(int sec)
    {
        Console.CursorVisible = false;

        for (int a = sec; a >= 0; a--)
        {
            Console.Write("/");
            Thread.Sleep(200);
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(200);
            Console.Write("\b \b");
            Console.Write(@"\");
            Thread.Sleep(200);
            Console.Write("\b \b");
            Console.Write("|");
            Thread.Sleep(200);
            Console.Write("\b \b");
        }
        Console.CursorVisible = true;
    }
    public void CountDown(int seconds)
    {
        for (int s = seconds; s >= 1; s--)
        {
            Console.CursorVisible = false;
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b\b ");
        }
        Console.CursorVisible = true;
    }
    public static List<string> LoadFile(string fileName)
    {
        List<string> lists = new List<string>();
        string[] lines = System.IO.File.ReadAllLines(fileName);
        foreach (string line in lines)
        {
            lists.Add(line);
        }
        return lists;
    }
    public void SetActivityType(string activityType)
    {
        _activityType = activityType;
    }
    public void SetSeconds(int seconds)
    {
        _seconds = seconds;
    }
    public Stopwatch GetStopwatch()
    {
        return _stopwatch;
    }
}