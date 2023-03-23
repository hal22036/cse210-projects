public abstract class Animal
{
    protected string AnimalName { get; set; }
    protected string Sound { get; set; }
    protected string Eat { get; set; }
    protected string Hair { get; set; }
    protected string Movement { get; set; }
    public Animal(string animalName, string sound, string eat, string hair, string movement)
    {
        AnimalName = animalName;
        Sound = sound;
        Eat = eat;
        Hair = hair;
        Movement = movement;
    }
    public abstract void DisplayAnimal();
    public void DisplaySound()
    {
        Console.Clear();
        Console.WriteLine(Sound);
    }
    public void PetAnimal()
    {
        Console.Clear();
        int startLine = Console.CursorTop;
        string[] frames = {"""
                     ___   ___
                     OOO   OOO|
            __       OOO   OOO|
            OOO      OOO   OOO|
             \OO\    |OO\  |OOO
              \OO|\  OOO\  |OOO
               \OOO\  OOO  |OOO          OO
          /O    \OOO\ |OOOOOOOO        /OOO|
          \OOO   \OOOOOOOOOOOOO       /OOOO
            OOOOO /OOOOOOOOOOOOO\  __/OOOO
              \OOOOOOOOOOOOOOOOOOOOOOOOl/
                “\OOOOOOOOOOOOOOOOOOOOO/
                 ''\OOOOOOOOOOOOOOOOOOO/
                   \OOOOOOOOOOOOOOOOO/
                    \OOOOOOOOOOOOOOO
                     ""OOOOOOOOOOO
                       ""OOOOOOOO|
                        |OOOOOOOO|
                        |OOOOOOOO|
        """,
        """
                       ___ ___
                       OOO OOO|
                 __    OOO OOO|
                 OOO   OOO OOO|
                 |OO|  |OO\|OOO
                 |OO|| OOO\|OOO
                 |OOO|  OOO|OOO       OO
            |OO  |OOO\|OOOOOOOO     /OOO|
            |OOO \OOOOOOOOOOOOO    /OOOO
             OOOOOOOOOOOOOOOOOO\__/OOOO/
              \OOOOOOOOOOOOOOOOOOOOOOOOl
                “\OOOOOOOOOOOOOOOOOOOOO|
                 |OOOOOOOOOOOOOOOOOOOO/
                   \OOOOOOOOOOOOOOOOO/
                    \OOOOOOOOOOOOOOO
                     ""OOOOOOOOOOO
                       ""OOOOOOOO|
                        |OOOOOOOO|
                        |OOOOOOOO|
        """,
        """
                     ___   ___
                     OOO   OOO|
            __       OOO   OOO|
            OOO      OOO   OOO|
             \OO\    |OO\  |OOO
              \OO|\  OOO\  |OOO
               \OOO\  OOO  |OOO          OO
          /O    \OOO\ |OOOOOOOO        /OOO|
          \OOO   \OOOOOOOOOOOOO       /OOOO
            OOOOO /OOOOOOOOOOOOO\  __/OOOO
              \OOOOOOOOOOOOOOOOOOOOOOOOl/
                “\OOOOOOOOOOOOOOOOOOOOO/
                 ''\OOOOOOOOOOOOOOOOOOO/
                   \OOOOOOOOOOOOOOOOO/
                    \OOOOOOOOOOOOOOO
                     ""OOOOOOOOOOO
                       ""OOOOOOOO|
                        |OOOOOOOO|
                        |OOOOOOOO|
        """,
        """
                       ___ ___
                       OOO OOO|
                 __    OOO OOO|
                 OOO   OOO OOO|
                 |OO|  |OO\|OOO
                 |OO|| OOO\|OOO
                 |OOO|  OOO|OOO       OO
            |OO  |OOO\|OOOOOOOO     /OOO|
            |OOO \OOOOOOOOOOOOO    /OOOO
             OOOOOOOOOOOOOOOOOO\__/OOOO/
              \OOOOOOOOOOOOOOOOOOOOOOOOl
                “\OOOOOOOOOOOOOOOOOOOOO|
                 |OOOOOOOOOOOOOOOOOOOO/
                   \OOOOOOOOOOOOOOOOO/
                    \OOOOOOOOOOOOOOO
                     ""OOOOOOOOOOO
                       ""OOOOOOOO|
                        |OOOOOOOO|
                        |OOOOOOOO|
        """};
        foreach (string frame in frames)
        {
            Console.Write(frame.TrimEnd());
            Thread.Sleep(700);
            Console.SetCursorPosition(0, startLine);
        }
        Console.WriteLine($"\n\nThank you for petting the {AnimalName}!");
    }
    public abstract void FeedAnimal();
    public void AnimalFacts()
    {
        Console.Clear();
        Console.WriteLine($"\nWhat their body covering is like: {Hair}");
        Console.WriteLine($"\nHow they move: {Movement}");
    }
}