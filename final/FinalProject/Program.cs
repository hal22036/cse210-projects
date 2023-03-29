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
                                menu.VisitAnimal(cow);
                                break;
                            case 2:
                                Elephant elephant = new Elephant();
                                menu.VisitAnimal(elephant);
                                break;
                            case 3:
                                Horse horse = new Horse();
                                menu.VisitAnimal(horse);
                                break;
                            case 4:
                                Monkey monkey = new Monkey();
                                menu.VisitAnimal(monkey);
                                break;
                            case 5:
                                Pig pig = new Pig();
                                menu.VisitAnimal(pig);
                                break;
                            case 6:
                                menu.Option = 0;
                                Rabbit rabbit = new Rabbit();
                                menu.VisitAnimal(rabbit);
                                break;
                            default:
                                if (menu.Option != 7)
                                {
                                    Console.WriteLine("\nPlease try again.");
                                }
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
                                menu.VisitAnimal(fish);
                                break;
                            case 2:
                                Frog frog = new Frog();
                                menu.VisitAnimal(frog);
                                break;
                            case 3:
                                Turtle turtle = new Turtle();
                                menu.VisitAnimal(turtle);
                                break;
                            default:
                                if (menu.Option != 4)
                                {
                                    Console.WriteLine("\nPlease try again.");
                                }
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
                                menu.VisitAnimal(duck);
                                break;
                            case 2:
                                Eagle eagle = new Eagle();
                                menu.VisitAnimal(eagle);
                                break;
                            case 3:
                                Parrot parrot = new Parrot();
                                menu.VisitAnimal(parrot);
                                break;
                            default:
                                if (menu.Option != 4)
                                {
                                    Console.WriteLine("\nPlease try again.");
                                }
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