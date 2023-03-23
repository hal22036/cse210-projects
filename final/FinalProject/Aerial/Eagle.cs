public class Eagle : Animal
{
    public Eagle() : base("Eagle", "A bald eagle has several distinct calls. The adult calls consist mostly of a series of high-pitched whistling or piping notes. The female has a distinctive mating call, a protracted low, soft note. The call of a bald eagle has sometimes been described as weak and as a cackling type of laugh. Juveniles and young have a “begging” call. There is also a low kuk-kuk-kuk call.", "Bald eagles are opportunistic foragers but prefer fish as their primary food and are found in great densities where fish are abundant. They also eat sea birds and ducks or hunt over grasslands and marshes for small mammals such as rabbits, squirrels, prairie dogs and muskrats.", "feathers -A bald eagle's body is mostly covered with skin and feathers.", "An eagle has 2 legs to walk on and 2 massive wings. These large birds move through the landscape primarily by soaring—a style of flying where they hold their wings outward and rarely flap, saving them considerable energy.") { }
    public override void DisplayAnimal()
    {
        Console.Clear();
        Console.WriteLine("""
                   .   ,
                 '. '.  \  \
               ._ '-.'. `\  \
                '-._; .'; `-.'. 
               `~-.; '.       '.
                '--,`           '.
                   -='.          ;
        .--=~~=-,    -.;        ;
         .-=`;    `~,_.;        /
        `  ,-`'    .-;         |
           .-~`.    .;         ;
            .;.-   .-;         ,\
              `.'   ,=;     .-'  `~.-._
               .';   .';  .'      .'   '-.
                 .\  ;  ;        ,.' _  a',
                .'~";-`   ;      ;"~` `'-=.)
              .' .'   . _;  ;',  ;
              '-.._`~`.'  \  ; ; :
                   `~'    _'\\_ \\_ 
                         /=`^^=`""/`)-.
                         \ =  _ =     =\
                          `""` `~-. =   ;
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