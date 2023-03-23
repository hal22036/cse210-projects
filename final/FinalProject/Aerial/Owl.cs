public class Owl : Animal
{
    public Owl() : base("Owl", "Owls make a variety of loud, continuous sounds, including hoots, barks, whistles, coos, and cries. People most closely associate the birds with their hooting, which is deep and soft and used to claim territory and call for mates. Their other noises are typically more high pitched and sound like singing or cooing.", "Owls eat a variety of small animals, including mice, rats, frogs, birds, squirrels, snakes, fish, and lizards.", "Many owls look bigger than they really are because they are heavily covered with feathers from top to bottom. In most species, female and male owls have similar feather colors and markings, but the female is usually larger than the male. Adult owls lose their feathers and grow new ones every year.", "Owls have 2 feet or talons which they walk and climb with. They also have 2 wings. They have large wings relative to their body mass, which let them fly unusually slowly—as slowly as two mph for a large species like the Barn Owl—by gliding noiselessly with little flapping. Additionally, the structure of their feathers serves as a silencer.") { }
    public override void DisplayAnimal()
    {
        Console.Clear();
        Console.WriteLine(""" 
             __________
            / ___  ___ \
           / / @ \/ @ \ \
           \ \___/\___/ /\
            \____\/____/||
            /     /\\\\\//
           |     |\\\\\\
            \      \\\\\\
             \______/\\\\
              _||_||_
        """);
    }
    public override void FeedAnimal()
    {
        Console.Clear();
        Console.WriteLine(Eat);
        Console.WriteLine($"\nYou are going to feed the {AnimalName} fish today!\n\n\n");
        Console.WriteLine("""
              /`·.¸
            /¸...¸`:·
        ¸.·´  ¸   `·.¸.·´)
        : © ):´;      ¸  {
        `·.¸ `·  ¸.·´\`·¸)
            `\\´´\¸.·´
        """);
        Console.WriteLine($"\n\nYum Yum Yum! Thank you for feeding the {AnimalName}");
    }

}