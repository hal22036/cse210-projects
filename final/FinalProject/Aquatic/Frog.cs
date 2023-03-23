public class Frog : Animal
{
    public Frog() : base("Frog", "Frogs can chirp, whistle, croak, ribbit, peep, cluck, bark and grunt", "Adult frogs eat insects that they catch with their long, sticky tongue, and other invertebrates such as snails, slugs and worms.", "The frog is covered by a soft, thin, moist skin composed of two layers, an outer epidermis and an inner dermis.", "Frogs have 4 legs. They have powerful muscles in their back legs, allowing them to hop great distances. Some frogs can jump over 20 times their own body length, which is similar to a human jumping 30 meters.") { }
    public override void DisplayAnimal()
    {
        Console.Clear();
        Console.WriteLine(""" 
                ,-.___.-.
             ,-.(|)   (|),-.
             \_*._ ' '_.* _/
              /`-.`--' .-'\
         ,--./    `---'    \,--.
         \   |(  )     (  )|   /
          \  | ||       || |  /
           \ | /|\     /|\ | /
           /  \-._     _,-/  \
          //| \\  `---'  // |\\
         /,-.,-.\       /,-.,-.\
        o   o   o      o   o    o
        """);
    }
    public override void FeedAnimal()
    {
        Console.Clear();
        Console.WriteLine(Eat);
        Console.WriteLine($"\nYou are going to feed the {AnimalName} a snail today!\n\n\n");
        Console.WriteLine("""
             .----.   @   @
            / .-"-.`.  \v/
            | | '\ \ \_/ )
          ,-\ `-.' /.'  /
         '---`----'----'
        """);
        Console.WriteLine($"\n\nYum Yum Yum! Thank you for feeding the {AnimalName}");
    }
}