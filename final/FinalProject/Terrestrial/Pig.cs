public class Pig : Animal
{
    public Pig() : base("Pig", "oinking; oinks; oinked -An oink is the sound a pig makes.", "Pigs have simple stomachs and an efficient digestive system that enables them to eat a wide variety of plant and animal foods, including vegetation, roots, fruits, eggs, flowers, leaves, fish, and dead animals.", "The skin of pigs is composed of an epidermis and dermis with characteristics like those of human skin. Most pigs have rather a bristled sparse hair covering on their skin, although woolly-coated breeds such as the Mangalitsa exist.", "Pigs walk on 4 legs. They can jump up to 3 feet high. They also are really good swimmers.") { }
    public override void DisplayAnimal()
    {
        Console.Clear();
        Console.WriteLine("""
                                                    __
             ____               ________     ,',.`.
           \`''-.`-._..--...-'''        ```--':_ ) )
            `-.._` '              -..           ' /
     ,'`..__..'' -. _ `._                         \
    ('';`      _ ,''       .-'            ,'       :
     `-._     `*/     ,                  '      .  |
        _.:._   `-'`-'  ;   \                  ,'  ;
     .':::::'`    ,' \,'     :         ;          /
      `-..__        ,'/      |       ,'         ,'
            ``---;'` \ `     ;.____..-'`.     ,'\
                /   / \:    :            :   (\ `\
              ,'  .'   \    :           ;'   / )  )
             /,_,.;::.  `.   \         /   ,',',_(:::.
                          `.  `.     ,'  ;'
                           /,_,'::. `-'`':
    """);
    }
    public override void FeedAnimal()
    {
        Console.Clear();
        Console.WriteLine(Eat);
        Console.WriteLine($"\nYou are going to feed the {AnimalName} a strawberry today!\n\n\n");
        Console.WriteLine("""
                        _
                    /> //  __
                ___/ \// _/ /
              ,' , \_/ \/ _/__
             /    _/ |--\  `  `~,
            ' , ,/  /`\ / `  `   `,
            |    |  |  \> `  `  ` |
            |  ,  \/ ' '    `  `  /
            `,   '  '    ' `  '  /
              \ `      '  ' ,  ,'
               \ ` ` '    ,  ,/
                `,  `  '  , ,'
                  \ `  ,   /        
                   `~----~'
        """);
        Console.WriteLine($"\n\nYum Yum Yum! Thank you for feeding the {AnimalName}");
    }
}