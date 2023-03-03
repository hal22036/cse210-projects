using System;
public class Word
{
    private string _word;
    private bool _visibility;
    public Word()
    {
        _word = null;
        _visibility = true;
    }
    public Word(string word, bool visibility=true)
    {
        _word = word;
        _visibility = visibility;
    }
    public void Hide()
    {
        _visibility = false;
        string blank= "";
        foreach (char letter in _word)
        {
           blank += "_";
        }
        _word = blank;
    }
    public void SetVisibility(bool visibility)
    {
        _visibility = visibility;
    }
    public bool GetVisibility()
    {
        return _visibility;
    }
    public void SetWord(string word)
    {
        _word = word;
    }
    public string GetWord()
    {
        return _word;
    }    
}