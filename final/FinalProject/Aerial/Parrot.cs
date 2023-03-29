public class Parrot : Animal
{
    public Parrot() : base("Parrot", "Parrots squawk and talk. They can mimick actual words and sounds around them.", "Parrot's food intake consists of seeds, nut, fruits, vegetables, leafy vegetation, grasses and occasionally insects.", "Parrots have skin and lits of feathers that cover their body.", "Parrots have 2 feet they walk on and 2 wings that they fly with.") { }
    public override void DisplayAnimal()
    {
        Console.Clear();
        Console.WriteLine(""" 
                                   .
                                  | \/|
          (\   _                  ) )|/|
              (/            _----. /.'.'
        .-._________..      .' @ _\  .'   
        '.._______.   '.   /    (_| .')
          '._____.  /   '-/      | _.' 
           '.______ (         ) ) \
             '..____ '._       )  )
                .' __.--\  , ,  // ((
                '.'     |  \/   (_.'(  
                        '   \ .' 
                         \   (
                          \   '.
                           \ \ '.)
                            '-'-'
        """);
    }
    public override void FeedAnimal()
    {
        Console.Clear();
        Console.WriteLine(Eat);
        Console.WriteLine($"\nYou are going to feed the {AnimalName} grapes today!\n\n\n");
        Console.WriteLine("""
                    __
                __ {_/ 
                \_}\\ _
                   _\(_)_
                  (_)_)(_)_
                 (_)(_)_)(_)
                  (_)(_))_)  
                   (_(_(_)  
                    (_)_)  
                     (_)  
        """);
        Console.WriteLine($"\n\nYum Yum Yum! Thank you for feeding the {AnimalName}");
    }
}
