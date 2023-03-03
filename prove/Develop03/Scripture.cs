using System;
public class Scripture
{
    private List<Word> _words = new List<Word>();
    private Reference _reference;
    public Scripture()
    {
        _words = null;
        _reference = null;
    }
    public Scripture(string book, string chapter, string verse, string verseText)
    {
        if (verse.Contains("-"))
        {
            string[]  multiVerse = verse.Split("-");
            _reference = new Reference(book, int.Parse(chapter), int.Parse(multiVerse[0]), int.Parse(multiVerse[1]), verseText);
        }
        else 
        {
           _reference = new Reference(book, int.Parse(chapter), int.Parse(verse), verseText); 
        }
        
        foreach (string word in verseText.Split(" "))
        {
            Word newWord = new Word(word);
            _words.Add(newWord);
        }
    }
    public void HideWords(int num)
    {
        Random random = new Random();
        for (int i = 0; i < num; i++)
        {
            int randomIndex = random.Next(0,_words.Count());
            if(_words[randomIndex].GetVisibility())
            {
                _words[randomIndex].Hide();
            }
            else 
            {
                i--;
            }
            if(CompletelyHidden())
            {
                break;
            }
        }
    }
    public void MakeText()
    {
        foreach (string word in _reference.GetVerseText().Split(" "))
        {
            Word newWord = new Word(word);
            _words.Add(newWord);
        }
    }
    public bool CompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.GetWord().Contains("_"))
            {
                return false;
            }
        }
        return true;
    }
    public void SetReference(Reference reference)
    {
        _reference = reference;
    }
    public string GetReference()
    {
        return _reference.MakeReferenceText();
    }    
    public void SetWords(List<Word> verseWord)
    {
        _words = verseWord;
    }
    public List<Word> GetWords()
    {
        return _words;
    }
}