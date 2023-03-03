using System;

class Program
{
    static void Main(string[] args)
    {
        string response = "";
        List<string> library = LoadLibrary();

        while (response != "1")
        {
            Console.Clear();
            Console.Write("Select (1) Random scripture or (2) Add a new scripture ");
            response = Console.ReadLine();
            if (response.Contains("1"))
            {
                break;
            }
            else if (response.Contains("2"))
            {
                Console.Write("What is the name of the Book? ");
                string newBook = Console.ReadLine();
                Console.Write("What is the Chapter number? ");
                string newChapter = Console.ReadLine();
                Console.Write("What is the Verse(s) number? (ex 3-4 or 7) ");
                string newVerse = Console.ReadLine();
                Console.Write("Type the verse(s): ");
                string newVerseText = Console.ReadLine();

                string newScripture = ($"{newBook}|{newChapter}|{newVerse}|{newVerseText}");
                NewEntry(newScripture);
                library = LoadLibrary();
            }
        }

        Random random = new Random();

        string[] randomScripture = library[random.Next(0, library.Count())].Split("|");
        Scripture scripture = new Scripture(randomScripture[0], randomScripture[1], randomScripture[2], randomScripture[3]);


        while (response != "quit")
        {
            Console.Clear();
            Console.WriteLine($"{scripture.GetReference()}");
            foreach (Word word in scripture.GetWords())
            {
                Console.Write($"{word.GetWord()} ");
            }
            Console.WriteLine("\n\nPress ENTER to continue or type 'quit' to finish: ");
            response = Console.ReadLine();
            if (scripture.CompletelyHidden())
            {
                break;
            }
            scripture.HideWords(3);
        }
    }

    public static List<string> LoadLibrary()
    {
        List<string> scriptures = new List<string>();
        string[] lines = System.IO.File.ReadAllLines("ScriptureLibrary.txt");
        foreach (string line in lines)
        {
            scriptures.Add(line);
        }
        return scriptures;
    }

    public static void NewEntry(string newEntry)
    {
        List<string> oldLibrary = LoadLibrary();
        using (StreamWriter outputFile = new StreamWriter("ScriptureLibrary.txt"))
        {
            foreach (string line in oldLibrary)
            {
                outputFile.WriteLine(line);
            }
            outputFile.WriteLine(newEntry);
        }
    }

}