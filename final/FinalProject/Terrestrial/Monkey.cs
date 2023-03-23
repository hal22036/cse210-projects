public class Monkey : Animal
{
    public Monkey() : base("Monkey", "Various monkeys may hoot, scream, howl, coo, rumble, bark, pant, grunt, and much more.", "In the wild, most monkeys are omnivores, which means they eat both plants and meat. And all monkeys eat about the same things. Depending on their habitat, there may be some slight changes, but all monkeys eat fruits, leaves, seeds, nuts, flowers, vegetables, and insects.", "Monkeys have skin and fur covering their bodies. Monkeys are mammals. All mammals have hair or fur covering all or most of their bodies. Monkeys also have skin under their fur.", "Monkeys have 2 legs and 2 arms. They can walk on just their legs, but use all 4 limbs to get around. They swing, jump, walk and run.") { }
    public override void DisplayAnimal()
    {
        Console.Clear();
        Console.WriteLine("""
                             __,__
                    .--.  .-"     "-.  .--.
                   / .. \/  .-. .-.  \/ .. \
                  | |  '|  /   Y   \  |'  | |
                  | \   \  \ 0 | 0 /  /   / |
                   \ '- ,\.-"`` ``"-./, -' /
                    `'-' /_   ^ ^   _\ '-'`
                    .--'|  \._   _./  |'--. 
                  /`    \   \ `~` /   /    `\
                 /       '._ '---' _.'       \
                /           '~---~'   |       \
               /        _.             \       \
              /   .'-./`/        .'~'-.|\       \
             /   /    `\:       /      `\'.      \
            /   |       ;      |         '.`;    /
            \   \       ;      \           \/   /
             '.  \      ;       \       \   `  /
               '._'.     \       '.      |   ;/_
                 /__>     '.       \_ _ _/   ,  '--.
               .'   '.   .-~~~~~-. /     |--'`~~-.  \
              // / .---'/  .-~~-._/ / / /---..__.'  /
             ((_(_/    /  /      (_(_(_(---.__    .'
                       | |     _              `~~`
                       | |     \'.
                        \ '....' |
                         '.,___.'
        """);
    }
    public override void FeedAnimal()
    {
        Console.Clear();
        Console.WriteLine(Eat);
        Console.WriteLine($"\nYou are going to feed the {AnimalName} a banana today!\n\n\n");
        Console.WriteLine("""
           _
          //\
          V  \
          \  \_
            \,'.`-.
            |\ `. `.       
            ( \  `. `-.                        _,.-:\
              \ \   `.  `-._             __..--' ,-';/
              \ `.   `-.   `-..___..---'   _.--' ,'/
                `. `.    `-._        __..--'    ,' /
                  `. `-_     ``--..''       _.-' ,'
                    `-_ `-.___        __,--'   ,'
                      `-.__  `----''''    __.-'
                            `--..____..--
        """);
        Console.WriteLine($"\n\nYum Yum Yum! Thank you for feeding the {AnimalName}");
    }
}