public class Menus
{
    public int Option { get; set; }
    private List<string> animalMenu = new List<string>{
            "Look at the animal", "What sounds the animal makes", "Feed the animal", "Pet the animal", "Learn more facts", "Choose another animal"
        };
    public int MainMenu()
    {
        Console.Clear();
        List<string> mainMenu = new List<string>{
            "Terrestrial World", "Aquatic World", "Aerial World", "Interesting Random Facts", "Credits", "Leave the Zoo"
        };
        return Menu(mainMenu);
    }
    public void VisitAnimal(Animal animal)
    {
        Option = Menu(animalMenu);
        switch (Option)
        {
            case 1:
                Console.WriteLine();
                animal.DisplayAnimal();
                break;
            case 2:
                Console.WriteLine();
                animal.DisplaySound();
                break;
            case 3:
                Console.WriteLine();
                animal.FeedAnimal();
                break;
            case 4:
                Console.WriteLine();
                animal.PetAnimal();
                break;
            case 5:
                Console.WriteLine();
                animal.AnimalFacts();
                break;
            default:
                break;
        }
    }
    public int TerrestrialMenu()
    {
        List<string> terrestrial = new List<string>{
            "Cow", "Elephant", "Horse", "Monkey", "Pig", "Rabbit", "Main Menu"
        };
        Console.WriteLine("\nWelcome to the Terrestrial world!");
        Console.WriteLine("\n\n\"Terrestrial animals are animals which live on land. These animals have developed specific features that help them to survive and live on land. Most of these animals have legs, which help them to run fast. They have to run fast to catch their prey or to protect themselves from becoming prey of other animals (predators). They breathe through well-developed lungs. Some terrestrial animals have sharp teeth with pointed canines and sharp claws to catch their prey. These animals have well developed sense organ, which helps them to look for food in the dark night or by mere movement of their prey. These special adaptive features are common to most of the terrestrial animals. Condition on the land is not uniform everywhere. It varies from place to place. Mountain region and the Polar regions are very cold. Animals living there have developed several adaptations to adjust to these climatic conditions. Polar bear living in the polar region and Yak living at high mountain range have thick coat of fur on their body, which protects them from the chilling cold. Animals like Walrus, Seals and Penguins also live in freezing conditions. These animals have special adaptation called blubber (thick layer of fat).\"");
        Console.WriteLine("\nCurrent animals to visit:");
        return Menu(terrestrial);
    }
    public int AerialMenu()
    {
        List<string> aerial = new List<string>{
            "Duck", "Eagle", "Parrot", "Main Menu"
        };
        Console.WriteLine("\nWelcome to the Aerial world!");
        Console.WriteLine("\n\n\"Aerial animals are those which spent a greater part of their lives in the air. Flying is the main characteristic of this group. Most of the adaptation of aerial animals revolve around their flying. Most of the birds and bats belong to this group. The body of the birds is made light with hollow light bones. Their front legs (for limbs) are modified into wings, which help them to fly. Their bodies are covered with feathers. They have well developed lungs to breathe air. They have sharp claws to hold branches. Claws of eagle are specially designed to catch prey. Birds living in cold places like Siberia come to India during winter season as the climatic condition there is very harsh and also there is scarcity of food. Siberian crane travel thousands of miles and come to India in search of food, warmth and to give birth to their young ones. They travel in large groups. At the end of the winter they travel back to their original home land. This mass movement of the birds from their home to the comfort region in the harsh climatic condition and back is called migration.\"");
        Console.WriteLine("\nCurrent animals to visit:");
        return Menu(aerial);
    }
    public int AquaticMenu()
    {
        List<string> aquatic = new List<string>{
            "Fish", "Frog", "Turtle", "Main Menu"
        };
        Console.WriteLine("\nWelcome to the Aquatic world!");
        Console.WriteLine("\n\n\"Animals living in water are called aquatic animals. All aquatic animals are not found in the same type of water. Many kinds of fish, snails, snake, are found in fresh water i.e. streams, lakes etc. Animals like dolphins, sharks, curbs, seals starfish, jelly are found in salty water i.e. the sea and oceans. Most of the aquatic animals breathe air dissolved in water, through organs called gills. Animals like dolphins and whale breathe through their lungs. Aquatic animals have special body shape like spindle shaped, flattened or disc shape. Dog fish, spindle shaped sting ray has a flattened shape. Aquatic animals swim in water. They have special organs called fins or paddles, which help them in swimming.\"");
        Console.WriteLine("\nCurrent animals to visit:");
        return Menu(aquatic);
    }
    public int Menu(List<string> MenuOptions)
    {
        Console.WriteLine();
        Console.WriteLine("\tOptions: ");
        for (int i = 0; i < MenuOptions.Count(); i++)
        {
            Console.WriteLine($"\t{i + 1}. {MenuOptions[i]}");
        }
        Console.Write("Select a choice from the menu: ");
        Option = int.Parse(Console.ReadLine());
        return Option;
    }
    public void LoadRandomFacts()
    {
        Console.Clear();
        List<string> facts = System.IO.File.ReadAllLines("RandomFacts.txt").ToList();
        Random random = new Random();
        int index = random.Next(facts.Count());
        Console.WriteLine($"\n\n{facts[index]}");
        Console.WriteLine("\nTo learn more, go to this website: https://factanimal.com/animal-facts/ \n\n");
    }
    public void Credits()
    {
        Console.Clear();
        Console.WriteLine("Animal Facts");
        Console.WriteLine("credits: https://www.studyadda.com/notes/4th-class/science/animals/animals-and-their-habitat/6341#:~:text=Most%20of%20these%20animals%20have,breathe%20through%20well%2Ddeveloped%20lungs.&text=Some%20terrestrial%20animals%20have%20sharp,claws%20to%20catch%20their%20prey, https://apps.apple.com/us/app/cow-sounds/id1070670734, https://thedairyalliance.com/blog/udderly-unusual-cow-facts/#:~:text=Cows%20can%20run%20on%20average,all%20animals%20and%20most%20humans., https://handsongloves.com/fun-facts-about-your-horses-coat/#:~:text=A%20horse's%20coat%20has%20a,being%20replaced%2C%20as%20our%20does., www.thesprucepets.com, www.ducks.ca, https://www.reference.com/pets-animals/sound-eagle-make-8bef8e713d6c7141, americanornithology.org, owlcation.com, www.virginiaaquarium.com");

        Console.WriteLine("Animal ASCII");
        Console.WriteLine("credits: https://www.asciiart.eu/animals, https://ascii.co.uk/art/pig");

        Console.WriteLine("Animals Eat");
        Console.WriteLine("credits: https://safarisafricana.com/what-do-elephants-eat/, https://www.wwf.org.uk/learn/fascinating-facts/elephants#:~:text=An%20elephant's%20skin%20is%202.5,regular%20dust%20and%20mud%20baths, https://www.usdairy.com/news-articles/do-dairy-cows-eat-food-people-could-eat, https://www.nidirect.gov.uk/articles/welfare-horses-need-suitable-diet#:~:text=Horses%20are%20naturally%20grazers%2C%20they,pattern%20as%20closely%20as%20possible., https://study.com/academy/lesson/what-do-monkeys-eat-lesson-for-kids.html#:~:text=In%20the%20wild%2C%20most%20monkeys,flowers%2C%20vegetables%2C%20and%20insects., https://www.worldanimalprotection.us/blogs/what-do-pigs-eat#:~:text=Pigs%20have%20simple%20stomachs%20and,%2C%20fish%2C%20and%20dead%20animals., nationalzoo.si.edu, johnstonandjeff.co.uk");

        Console.WriteLine("Other Links");
        Console.WriteLine("https://www.quora.com/What-is-the-name-for-the-sounds-monkeys-make-What-do-scientist-think-the-sounds-represent#:~:text=Various%20monkeys%20may%20hoot%2C%20scream,%2C%20grunt%2C%20and%20much%20more., homework.study.com, wikipedia.org, www.vocabulary.com, www.rspca.org.uk, www.ncbi.nlm.nih.gov, www.merckvetmanual.com, www.wildlifecenter.org, journeynorth.org, www.crittercontrol.com, www.nycgovparks.org, owlresearchinstitute.org, audubon.org, www.blm.gov, www.fishandboat.com, www.quora.com, www.pbs.org, petnpat.com, petmd.com");
    }
}