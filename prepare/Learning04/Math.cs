using System;
public class Math : Assignment
{
    private string _textbookSection;
    private string _problems;
    public Math()
    {
        _textbookSection = null;
        _problems = null;
    }
    public Math(string textbookSection, string problems)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }
    
    public Math(string studentName, string topic, string textbookSection, string problems): base(studentName, topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }
    public string GetHomeworkList()
    {
        return $"Section {_textbookSection} Problems {_problems}";
    }

    public string GetTextbookSection()
    {
        return _textbookSection;
    }
    public void SetTextbookSection(string textbookSection)
    {
        _textbookSection = textbookSection;
    }
    public string GetProblems()
    {
        return _problems;
    }
    public void SetProblems(string problems)
    {
        _problems = problems;
    }
}