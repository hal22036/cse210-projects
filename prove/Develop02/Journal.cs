using System;
using System.IO;
public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    public List<Scripture> _scriptures = new List<Scripture>();
    public void WriteEntry()
    {
        Entry entry = new Entry();
        Console.Write($"{entry._dateText}: {entry._prompt}:> ");
        entry._userText = Console.ReadLine();
        _entries.Add(entry);
    }

    public void ScriptureStudy()
    {
        Scripture scriptureStudy = new Scripture();
        Console.WriteLine("Begin with Prayer - Pray for Inspiration.");
        Console.WriteLine("Ponder what you want to get out of your study today.");
        Console.Write("What are you studying today? >");
        scriptureStudy._whatStudy = Console.ReadLine();
        Console.Write("What inspiration did you receive from you study today? >");
        scriptureStudy._inspiration = Console.ReadLine();
        _scriptures.Add(scriptureStudy);
    }
    public void DisplayJournal()
    {
        foreach (Entry entry in _entries)
        {
            Console.WriteLine($"{entry._dateText}: {entry._prompt}: {entry._userText}");
        }
        foreach (Scripture scripture in _scriptures)
        {
            Console.WriteLine($"{scripture._studyDate}: What I Studied ({scripture._whatStudy}): Inspiration I received -{scripture._inspiration}");
        }
        Console.ReadLine();
    }
    public void LoadJournal()
    {
        Console.Write("What is the file name? ");
        string filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split(": ");
            string _date = parts[0];
            string _usedPrompt = parts[1];
            string _userEntry = parts[2];
            Entry entry = new Entry();
            entry._dateText = _date;
            entry._prompt = _usedPrompt;
            entry._userText = _userEntry;
            _entries.Add(entry);
        }
    }
    public void SaveJournal()
    {
        Console.Write("What is the file name for your journal? ");
        string fileName = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._dateText}: {entry._prompt}: {entry._userText}");
            }
            foreach (Scripture scripture in _scriptures)
            {
                outputFile.WriteLine($"{scripture._studyDate}: What I Studied ({scripture._whatStudy}): Inspiration I received -{scripture._inspiration}");
            }
        }
    }
}
