public class Fish : Animal
{
    public Fish() : base("Fish", "Fish produce vocalizations that can tak a wide variety of forms, including pops, clicks, whistles, purrs, grunts, groans, growls, barks, hums, hoots, rattles, and even tinkles.", "Fish generally eat other fish but their diet can also consist of eggs, algae, plants, crustaceans, worms, mollusks, insects, insect larvae, amphibians, and plankton.", "Like most animals, all fish have skin. Many fish have an outer covering of scales. Scales protect fish, much like a suit of armor. All fish have a slimy covering of mucus.", "The fish's body pushes against the water and moves the fish forward. Fins help fine-tune swimming. The caudal fin, or tail fin, increases speed. The pectoral and pelvic fins steer up or down.") { }
    public override void DisplayAnimal()
    {
        Console.Clear();
        Console.WriteLine(""" 
                    o
        o      ______/~/~/~/__           /((
          o  // __            ====__    /_((
         o  //  @))       ))))      ===/__((
            ))           )))))))        __((
            \\     \)     ))))    __===\ _((
             \\_______________====      \_((
                                         \((
        """);
    }
    public override void FeedAnimal()
    {
        Console.Clear();
        Console.WriteLine(Eat);
        Console.WriteLine($"\nYou are going to feed the {AnimalName} a worm today!\n\n\n");
        Console.WriteLine("""
                                                        /~~\
          ____                                         /'o  |
        .';;|;;\            _,-;;;\;-_               ,'  _/'|
        `\_/;;;/;\         /;;\;;;;\;;;,             |     .'
            `;/;;;|      ,;\;;;|;;;|;;;|;\          ,';;\  |
            |;;;/;:     |;;;\;/~~~~\;/;;;|        ,;;;;;;.'
            |;/;;;|     |;;;,'      `\;;/;|      /;\;;;;/
            `|;;;/;\___/;~\;|         |;;;;;----\;;;|;;/'
            `;/;;;|;;;|;;;,'         |;;;;|;;;;;|;;|/'
             `\;;;|;;;/;;,'           `\;/;;;;;;|/~'
                `\/;;/;;;/               `~------'
                    `~~~~~  
        """);
        Console.WriteLine($"\n\nYum Yum Yum! Thank you for feeding the {AnimalName}");
    }
}