using System;
public class Job
{
    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;
    public Job()
    {

    }
    public void DisplayJob()
    {
        Console.WriteLine($"{_company} ({_jobTitle}) {_startYear}-{_endYear}");
    }
}