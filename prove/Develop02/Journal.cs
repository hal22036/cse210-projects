using System;
using System.IO;
public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    public Journal()
{

}
public void WriteEntry()
{
    Entry entry = new Entry();
    Console.Write($"{entry._dateText}> ");
    entry._userText = Console.ReadLine();
    _entries.Add(entry);
}
public void DisplayJournal()
{
    foreach (Entry entry in _entries)
    {
        entry.DisplayEntry();
    }    
}
public void LoadJournal()
{
foreach (Entry entry in _entries)
    {
        entry.LoadEntry();
    }
}
public void SaveJournal()
{    
    Console.Write("What is the file name? ");
    string fileName = Console.ReadLine();
    using (StreamWriter outputFile = new StreamWriter(fileName))
    {
        foreach (Entry entry in _entries)
    {
        outputFile.WriteLine($"{entry._dateText}: {entry._userText}");
    }
    }
}
}
