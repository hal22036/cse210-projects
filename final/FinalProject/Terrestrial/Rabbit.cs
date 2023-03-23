public class Rabbit : Animal
{
    public Rabbit() : base("Rabbit", "Snorting: Snorting can come before or along with growling. Hissing: This sounds exactly the way you think it does. A hiss is used to ward off other rabbits. Whining or whimpering: Rabbits will whine or whimper if they do not want to be handled.", "Fresh, clean drinking water and good quality hay and grass should make up the majority of your rabbits' diet. A rabbit's digestive system needs hay or grass to function properly so a healthy supply is extremely important. You can supplement with leafy greens and a small amount of pellets.", "Rabbits have very thin and delicate skin that is covered with fine fur comprised of both a soft undercoat and stiff guard hairs.", "Using their powerful hind legs, rabbits move by hopping. They have 4 toes on their hind feet that are long and webbed to keep them from spreading apart as they jump. Their front paws have 5 toes each. Some species of rabbit can reach speeds of 35 to 45 miles per hour (56 to 72 kilometers per hour).") { }
    public override void DisplayAnimal()
    {
        Console.Clear();
        Console.WriteLine("""
                                 /\    .-" /
                                /  ; .'  .' 
                               :   :/  .'   
                                \  ;-.'     
                   .--'"'"--..__/     `.    
                 .'           .'    `o  \   
                /                    `   ;  
               :                  \      :  
             .-;        -.         `.__.-'  
            :  ;          \     ,   ;       
            '._:           ;   :   (        
                \/  .__    ;    \   `-.     
                 ;     "-,/_..--"`-..__)    
                 '""--.._:
                
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