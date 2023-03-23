public class Elephant : Animal
{
    public Elephant() : base("Elephant", "Elephants communicate in a variety of ways - including sounds like trumpet calls (some sounds are too low for people to hear), body language, touch and scent. They can also communicate through seismic signals - sounds that create vibrations in the ground - which they may detect through their bones.", "Elephants are herbivorous animals. They eat leaves, twigs, bark, roots, fruit, flowers… everything. They even try to eat up the soul of a tree! But, it's not possible. If anything is green nearby, they tend to latch onto it. There is no looking right or left. To sustain such a gigantic figure, they have to eat that much. A twig of a tree is just a single spoon of dessert on their plate! Apart from that, they drink water from nearby ponds or rivers. They drink a lot of water to get them hydrated all the time. In some regions, they use water to control their body temperature. Elephants living in different regions of the planet eat different things. But the main diet remains the same. They are die-hard vegetarians!", "An elephant's skin is 2.5cm thick in most places. The folds and wrinkles in their skin can retain up to 10 times more water than flat skin does, which helps to cool them down. They keep their skin clean and protect themselves from sunburn by taking regular dust and mud baths.", "Elephants walk on 4 legs and can run up to 25 mph.") { }
    public override void DisplayAnimal()
    {
        Console.Clear();
        Console.WriteLine("""
                                 _
                               .' `'.__
                               /      \ `'"-,
              .-''''--...__..-/ .     |      \
            .'               ; :'     '.  a   |
           /                 | :.       \     =\
          ;                   \':.      /  ,-.__;.-;`
         /|     .              '--._   /-.7`._..-;`
        ; |       '                |`-'      \  =|
        |/\        .   -' /     /  ;         |  =/
        (( ;.       ,_  .:|     | /     /\   | =|
         ) / `\     | `""`;     / |    | /   / =/
           | ::|    |      \    \ \    \ `--' =/
          /  '/\    /       )    |/     `-...-`
         /    | |  `\    /-'    /;
         \  ,,/ |    \   D    .'  \
          `""`   \  nnh  D_.-'L__nnh
        """);
    }
    public override void FeedAnimal()
    {
        Console.Clear();
        Console.WriteLine(Eat);
        Console.WriteLine($"\nYou are going to feed the {AnimalName} a flower today!\n\n\n");
        Console.WriteLine("""
                .-~~-.--.
               :         )
         .~ ~ -.\       /.- ~~ .
         >       `.   .'       <
        (         .- -.         )
         `- -.-~  `- -'  ~-.- -'
           (        :        )           _ _ .-:
            ~--.    :    .--~        .-~  .-~  }        
                ~-.-^-.-~ \_      .~  .-~   .~
                         \ \'     \ '_ _ -~
                            `.`.    //
                    . - ~ ~-.__`.`-.//
                .-~   . - ~  }~ ~ ~-.~-.
              .' .-~      .-~       :/~-.~-./:
             /_~_ _ . - ~                 ~-.~-._
                                              ~-.<
        """);
        Console.WriteLine($"\n\nYum Yum Yum! Thank you for feeding the {AnimalName}");
    }
}
