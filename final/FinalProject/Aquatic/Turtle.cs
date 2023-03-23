public class Turtle : Animal
{
    public Turtle() : base("Turtle", "Turtles can produce an array of sounds ranging from hisses, croaks, grunts, honks, moans, or even squeals. All turtles can make a hissing sound. This hiss comes from when they retract into their shell, and the air whooshes out of them. It produces that hissing noise, even though it is more of a wheeze.", "Turtles are omnivores, which means they eat a combination of animal protein and vegetables. Some species, such as the spiny soft-shell turtle, are considered carnivorous and eat primarily animal protein. Typically, aquatic turtles eat more animal protein when they are young and more veggies as they get older. They do enjoy treats from time to time like fruits and insects.", "Turtles are reptiles and like all reptiles, they have scales. The scales on their shell are specialized plates called scutes (pronounced “scoots”).", "Turtles have 4 legs that they walk and climb with. These legs are shaped to help them swim well in water.") { }
    public override void DisplayAnimal()
    {
        Console.Clear();
        Console.WriteLine(""" 
                       _,.---.---.---.--.._ 
                   _.-' `--.`---.`---'-. _,`--.._
                  /`--._ .'.     `.     `,`-.`-._\
                 ||   \  `.`---.__`__..-`. ,'`-._/
            _  ,`\ `-._\   \    `.    `_.-`-._,``-.
         ,`   `-_ \/ `-.`--.\    _\_.-'\__.-`-.`-._`.
        (_.o> ,--. `._/'--.-`,--`  \_.-'       \`-._ \
         `---'    `._ `---._/__,----`           `-. `-\
                   /_, ,  _..-'                    `-._\
                   \_, \/ ._(
                    \_, \/ ._\
                     `._,\/ ._\
                       `._// ./`-._
                         `-._-_-_.-'
        """);
    }
    public override void FeedAnimal()
    {
        Console.Clear();
        Console.WriteLine(Eat);
        Console.WriteLine($"\nYou are going to feed the {AnimalName} cherries today!\n\n\n");
        Console.WriteLine("""
                          d888P
                d8b d8888P:::P
              d:::888b::::::P
             d:::dP8888b:d8P
            d:::dP 88b  Yb   .d8888b.
           d::::P  88Yb  Yb .P::::::Y8b
           8:::8   88`Yb  YbP::::   :::b
           8:::P   88 `8   8!:::::::::::b
           8:dP    88  Yb d!!!::::::::::8
           8P    ..88   Yb8!!!::::::::::P
            .d8:::::Yb  d888VKb:!:!::!:8
           d::::::  ::dP:::::::::b!!!!8
          8!!::::::::P::::::::::::b!8P
          8:!!::::::d::::::: ::::::b
          8:!:::::::8!:::::::  ::::8
          8:!!!:::::8!:::::::::::::8
          Yb:!!:::::8!!::::::::::::8
           8b:!!!:!!8!!!:!:::::!!:dP
            `8b:!!!:Yb!!!!:::::!d88
                '''  Y88!!!!!!!d8P
                        ''''''''
        """);
        Console.WriteLine($"\n\nYum Yum Yum! Thank you for feeding the {AnimalName}");
    }
}