using System;
public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;
    private string _verseText;

    public Reference()
    {
        _book = null;
        _chapter = 0;
        _verse = 0;
        _endVerse = 0;
        _verseText = null;
    }
    public Reference(string book, int chapter, int verse, string verseText)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = -1;
        _verseText = verseText;
    }
    public Reference(string book, int chapter, int verse, int endVerse, string verseText)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
        _verseText = verseText;
    }
    public string MakeReferenceText()
    {
        if (this.GetEndVerse() != -1)
        {
            return $"{this.GetBook()} {this.GetChapter()}:{this.GetVerse()}-{this.GetEndVerse()}";
        }
        else
        {
            return $"{this.GetBook()} {this.GetChapter()}:{this.GetVerse()}";
        }
    }
    public void SetBook(string book)
    {
        _book = book;
    }
    public string GetBook()
    {
        return _book;
    }
    public void SetChapter(int chapter)
    {
        _chapter = chapter;
    }
    public int GetChapter()
    {
        return _chapter;
    }
public void SetVerse(int verse)
    {
        _verse = verse;
    }
    public int GetVerse()
    {
        return _verse;
    }
    public void SetEndVerse(int endVerse)
    {
        _endVerse = endVerse;
    }
    public int GetEndVerse()
    {
        return _endVerse;
    }
    public void SetVerseText(string verseText)
    {
        _verseText = verseText;
    }
    public string GetVerseText()
    {
        return _verseText;
    }
}