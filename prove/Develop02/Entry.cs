using System;
using System.IO;

public class Entry
{
    public string _dateText = DateTime.Now.ToShortDateString();
    public string _userText;

    public void DisplayEntry()
    {
        Console.WriteLine($"{_dateText}: {_userText}");
    }
    public void LoadEntry()
    {
        string filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split(",");
            string _date = parts[0];
            string _userEntry = parts[1];
        }
    }
}

