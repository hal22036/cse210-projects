using System;
public class Writing : Assignment
{
    private string _title;
    public Writing()
    {
        _title = null;
    }
    public Writing(string title)
    {
        _title = title;
    }
    public Writing(string studentName, string topic, string title) : base(studentName, topic)
    {
        _title = title;
    }
    public string GetWritingInformation()
    {
        return $"{_title} by {GetStudentName()}";
    }

    public string GetTitle()
    {
        return _title;
    }
    public void SetTitle(string title)
    {
        _title = title;
    }
}
