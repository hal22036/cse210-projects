public class Cow : Animal
{
    public Cow() : base("Cow", "Everyone knows that cows say moo - but did you know that cattle also grunt, snort and bellow? In bovine communication, different sounds are made to communicate different things - from a tender bellow from a mother cow to her baby calf, to aggressive snorts made as a warning to stand down.", "Cows Diet consists of= Grass: More than 50 percent of cow feed is actually grass (farmers call it hay and silage). While people often think dairy cows are fed a high-grain diet, in reality they eat the leaves and stems from corn, wheat and oats far more often than they are eating grain, like corn kernels. Grain: Dairy cows do eat some grain, which usually makes up less than one-quarter of their diet. Some has been grown specifically for cows, and other types have been recycled after food or beverage production -- like barley that has been used first to brew beer. The rest of a cow's diet includes ingredients like almond hulls, canola meal (the leftovers from producing canola oil), citrus pulp (the leftovers from making orange juice and other beverages) and more. Here's the cool thing: These products, which were once thrown away, are actually good for cows. Cows can “unlock” the energy and nutrients in these products that would otherwise go to waste.", "Cowhide is the natural, unbleached skin and hair of a cow. It retains the original coloring of the animal.", "Cows walk on 4 legs. They can run up to 25 mph, but only in short bursts.") { }
    public override void DisplayAnimal()
    {
        Console.Clear();
        Console.WriteLine("""
                                                    /;    ;\
                                                __  \\____//
                                               /{_\_/   `'\____
                                               \___   (o)  (o  }
                    _____________________________/          :--'  
                ,-,'`@@@@@@@@       @@@@@@         \_    `__\
               ;:(  @@@@@@@@@        @@@             \___(o'o)
               :: )  @@@@          @@@@@@        ,'@@(  `===='       
               :: : @@@@@:          @@@@         `@@@:
               :: \  @@@@@:       @@@@@@@)    (  '@@@'
               ;; /\      /`,    @@@@@@@@@\   :@@@@@)
               ::/  )    {_----------------:  :~`,~~;
              ;;'`; :   )                  :  / `; ;
             ;;;; : :   ;                  :  ;  ; :              
             `'`' / :  :                   :  :  : :
                 )_ \__;      ";"          :_ ;  \_\       `,','
                 :__\  \    * `,'*         \  \  :  \   *  8`;'*  *
                     `^'     \ :/           `^'  `-^-'   \v/ :  \/ 
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