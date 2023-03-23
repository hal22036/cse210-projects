class Program
{
    static void Main(string[] args)
    {
        Menus menu = new Menus();
        while (menu.Option != 6)
        {
            Console.WriteLine("Welcome to the Petting Zoo!");
            Console.WriteLine("\nWhere Would you like to visit?");
            switch (menu.MainMenu())
            {
                case 1:
                    while (menu.Option != 7)
                    {
                        switch (menu.TerrestrialMenu())
                        {
                            case 1:
                                Cow cow = new Cow();
                                while (menu.Option != 6)
                                {
                                    menu.VisitAnimal(cow);
                                }
                                break;
                            case 2:
                                Elephant elephant = new Elephant();
                                while (menu.Option != 6)
                                {
                                    menu.VisitAnimal(elephant);
                                }
                                break;
                            case 3:
                                Horse horse = new Horse();
                                while (menu.Option != 6)
                                {
                                    menu.VisitAnimal(horse);
                                }
                                break;
                            case 4:
                                Monkey monkey = new Monkey();
                                while (menu.Option != 6)
                                {
                                    menu.VisitAnimal(monkey);
                                }
                                break;
                            case 5:
                                Pig pig = new Pig();
                                while (menu.Option != 6)
                                {
                                    menu.VisitAnimal(pig);
                                }
                                break;
                            case 6:
                                Rabbit rabbit = new Rabbit();
                                while (menu.Option != 6)
                                {
                                    menu.VisitAnimal(rabbit);
                                }
                                break;
                            default:
                                Console.WriteLine("\nPlease try again.");
                                break;
                        }
                    }
                    break;
                case 2:
                    while (menu.Option != 4)
                    {
                        switch (menu.AquaticMenu())
                        {
                            case 1:
                                Fish fish = new Fish();
                                while (menu.Option != 6)
                                {
                                    menu.VisitAnimal(fish);
                                }
                                break;
                            case 2:
                                Frog frog = new Frog();
                                while (menu.Option != 6)
                                {
                                    menu.VisitAnimal(frog);
                                }
                                break;
                            case 3:
                                Turtle turtle = new Turtle();
                                while (menu.Option != 6)
                                {
                                    menu.VisitAnimal(turtle);
                                }
                                break;
                            default:
                                Console.WriteLine("\nPlease try again.");
                                break;
                        }
                    }
                    break;
                case 3:
                    while (menu.Option != 4)
                    {
                        switch (menu.AerialMenu())
                        {
                            case 1:
                                Duck duck = new Duck();
                                while (menu.Option != 6)
                                {
                                    menu.VisitAnimal(duck);
                                }
                                break;
                            case 2:
                                Eagle eagle = new Eagle();
                                while (menu.Option != 6)
                                {
                                    menu.VisitAnimal(eagle);
                                }
                                break;
                            case 3:
                                Parrot parrot = new Parrot();
                                while (menu.Option != 6)
                                {
                                    menu.VisitAnimal(parrot);
                                }
                                break;
                            default:
                                Console.WriteLine("\nPlease try again.");
                                break;
                        }
                    }
                    break;
                case 4:
                    menu.LoadRandomFacts();
                    break;
                case 5:
                    menu.Credits();
                    break;
            }
        }
    }
}