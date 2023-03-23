public class Horse : Animal
{
    public Horse() : base("Horse", "neighing; neighed; neighs The sound that a horse makes is called a neigh. A horse's happy neigh is sometimes a greeting to other horses. You can use neigh to talk about the noise your horse makes, also known as a whinny or a bray.", "Horses are naturally grazers, they eat little and often. Their natural diet is mainly grass, which has high roughage content. Horses should be provided with a predominantly fibre-based diet, either grass, hay, haylage or a hay replacement in order to mimic their natural feeding pattern as closely as possible.", "A horse's coat has a few different types of hair. Temporary hair is your horse's body hair -the majority of the coat! Manes and tails are permanent hairs, as they don't shed as their temporary body hair does. There will always be hair naturally falling out and being replaced, as our does. The whiskers, eyebrows, and ear hair is considered tactile hair. Also called vibrissae, these hairs help your horse navigate and feel things around him that he can't see.", "Horses walk on 4 legs and can run up to 55mph.") { }
    public override void DisplayAnimal()
    {
        Console.Clear();
        Console.WriteLine("""
                                  _(\_/) 
                                ,((((^`\
                               ((((  (6 \ 
                             ,((((( ,    \
         ,,,_              ,(((((  /"._  ,`,
        ((((\\ ,...       ,((((   /    `-.-'
        )))  ;'    `"'"'""((((   (      
        (((  /            (((      \
         )) |                      |
        ((  |        .       '     |
        ))  \     _ '      `t   ,.')
        (   |   y;- -,-""'"-.\   \/  
        )   / ./  ) /         `\  \
            |./   ( (           / /'
            ||     \\          //'|
            ||      \\       _//'||
            ||       ))     |_/  ||
            \_\     |_/          ||
            `'"                  \_\
        """);
    }
    public override void FeedAnimal()
    {
        Console.Clear();
        Console.WriteLine(Eat);
        Console.WriteLine($"\nYou are going to feed the {AnimalName} grass today!\n\n\n");
        Console.WriteLine("""
                 |
                \|/|/
             \|\\|//|/
              \|\|/|/
               \\|//
                \|/
                \|/
                 |
           _\|/__|_\|/____\|/_
        """);
        Console.WriteLine($"\n\nYum Yum Yum! Thank you for feeding the {AnimalName}");
    }
}