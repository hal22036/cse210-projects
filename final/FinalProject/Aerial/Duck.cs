public class Duck : Animal
{
    public Duck() : base("Duck", "quacks; quacking; quacked; quacker -A good quack is the sound a duck makes.", "Wild ducks and geese feed on a variety of grains and grasses, aquatic plants, and invertebrates, all naturally found in the wild. When eaten in combination, these foods are nutritionally balanced and provide everything a wild duck or goose needs to survive.", "Ducks have a relatively thin skin covered with feathers. Since ducks are aquatic, they have preen glands with oil on the base of their tail; this oil is spread on the feathers to keep the duck dry while floating on the water.", "Ducks have 2 feet they walk on and 2 wings. They must flap their wings fast — about 10 times per second — to keep their relatively large bodies airborne. Duck wings are long and pointed, like those of a peregrine falcon, the fastest bird on Earth. With this wing shape and rapid wingbeat, most ducks can fly at 80 kilometres per hour!") { }
    public override void DisplayAnimal()
    {
        Console.Clear();
        Console.WriteLine(""" 
                     _.-.
                __.-' ,  \
               '--'-'._   \
                       '.  \
                        )-- \ __.--._
                       /   .'        '--.
                      .               _/-._
                      :       ____._/   _-'
                      '._          _.'-'
                         '-._    _.'
                             \_|/
                            __|||
                            >__/'
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