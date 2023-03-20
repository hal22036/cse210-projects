using System;
class Program
{
    static void Main(string[] args)
    {
        int answer = 0;
        int pointTotal = 0;
        List<Goal> goals = new List<Goal>();
        List<Goal> rewards = new List<Goal>();
        void LoadFile()
        {
            string[] lines = System.IO.File.ReadAllLines("Goals.txt");
            foreach (string line in lines)
            {
                string[] splitLine = line.Split("|");
                if (splitLine[0] == "Simple Goal")
                {
                    SimpleGoal simpleGoal = new SimpleGoal(splitLine[1], splitLine[2], int.Parse(splitLine[3]), int.Parse(splitLine[4]));
                    goals.Add(simpleGoal);
                }
                else if (splitLine[0] == "Eternal Goal")
                {
                    EternalGoal eternalGoal = new EternalGoal(splitLine[1], splitLine[2], int.Parse(splitLine[3]), int.Parse(splitLine[4]));
                    goals.Add(eternalGoal);
                }
                else if (splitLine[0] == "Checklist Goal")
                {
                    ChecklistGoal checklistGoal = new ChecklistGoal(splitLine[1], splitLine[2], int.Parse(splitLine[3]), int.Parse(splitLine[4]), int.Parse(splitLine[5]), int.Parse(splitLine[6]));
                    goals.Add(checklistGoal);
                }
                else if (splitLine[0] == "Reward")
                {
                    RewardGoal rewardGoal = new RewardGoal(splitLine[1], splitLine[2], int.Parse(splitLine[3]));
                    rewards.Add(rewardGoal);
                }
            }
        }
        void SaveFile()
        {
            string[] lines = System.IO.File.ReadAllLines("Goals.txt");
            using (StreamWriter outputFile = new StreamWriter("Goals.txt"))
            {
                foreach (string line in lines)
                {
                    outputFile.WriteLine(line);
                }
            }
        }
        int GetTotalPoints()
        {
            pointTotal = 0;
            foreach (Goal goal in goals)
            {
                pointTotal += goal.GetPoints();
            }
            foreach (Goal reward in rewards)
            {
                if (reward.GetComplete() == 'X')
                {
                    pointTotal -= reward.GetPoints();
                }
            }
            return pointTotal;
        }
        void DisplayAllGoals(List<Goal> displayList)
        {
            for (int i = 0; i < displayList.Count(); i++)
            {
                Console.WriteLine($"\t{i + 1}) {displayList[i].DisplayGoal()}");
            }
        }
        void UpdateFile()
        {
            using (StreamWriter outputFile = new StreamWriter("Goals.txt"))
            {
                foreach (Goal goal in goals)
                {
                    outputFile.WriteLine(goal.FormatToString());
                }
                foreach (Goal reward in rewards)
                {
                    outputFile.WriteLine(reward.FormatToString());
                }
            }
        }
        while (answer != 9)
        {
            Console.WriteLine($"You have {GetTotalPoints()} points.");
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("   1. Create New Goal");
            Console.WriteLine("   2. List Goals");
            Console.WriteLine("   3. Save Goals");
            Console.WriteLine("   4. Load Goals");
            Console.WriteLine("   5. Record Event");
            Console.WriteLine("   6. Create New Reward");
            Console.WriteLine("   7. View Rewards");
            Console.WriteLine("   8. Collect Rewards");
            Console.WriteLine("   9. Quit");
            Console.Write("Select a choice from the menu: ");
            answer = int.Parse(Console.ReadLine());
            Console.Clear();
            switch (answer)
            {
                case 1:
                    Console.WriteLine("The types of Goals are:");
                    Console.WriteLine("   1. Simple Goal");
                    Console.WriteLine("   2. Eternal Goal");
                    Console.WriteLine("   3. Checklist Goal");
                    Console.Write("Which type of goal would you like to create? ");
                    answer = int.Parse(Console.ReadLine());
                    Console.Write("What is the name of your goal? ");
                    string newGoal = Console.ReadLine();
                    Console.Write("What is a short description of your goal? ");
                    string goalDescription = Console.ReadLine();
                    Console.Write("What is the amount of points associated with this goal? ");
                    int points = int.Parse(Console.ReadLine());
                    switch (answer)
                    {
                        case 1:
                            SimpleGoal simple = new SimpleGoal(newGoal, goalDescription, points);
                            goals.Add(simple);
                            UpdateFile();
                            break;
                        case 2:
                            EternalGoal eternal = new EternalGoal(newGoal, goalDescription, points);
                            goals.Add(eternal);
                            UpdateFile();
                            break;
                        case 3:
                            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                            int goalAmount = int.Parse(Console.ReadLine());
                            Console.Write("What is the bonus for accomplishing it that many times? ");
                            int bonus = int.Parse(Console.ReadLine());
                            ChecklistGoal checklist = new ChecklistGoal(newGoal, goalDescription, points, goalAmount, bonus);
                            goals.Add(checklist);
                            UpdateFile();
                            break;
                    }
                    break;
                case 2:
                    Console.WriteLine("The goals are:");
                    DisplayAllGoals(goals);
                    break;
                case 3:
                    SaveFile();
                    break;
                case 4:
                    LoadFile();
                    break;
                case 5:
                    DisplayAllGoals(goals);
                    Console.Write("Which goal did you complete? ");
                    goals[int.Parse(Console.ReadLine()) - 1].CompleteGoal();
                    UpdateFile();
                    break;
                case 6:
                    Console.Write("What is the name of your reward? ");
                    string reward = Console.ReadLine();
                    Console.Write("What are the details of your reward? ");
                    string rewardDescription = Console.ReadLine();
                    Console.Write("How many points do you need to reach your reward? ");
                    int rewardPoints = int.Parse(Console.ReadLine());
                    RewardGoal newReward = new RewardGoal(reward, rewardDescription, rewardPoints);
                    rewards.Add(newReward);
                    UpdateFile();
                    break;
                case 7:
                    Console.WriteLine("The rewards are: ");
                    DisplayAllGoals(rewards);
                    break;
                case 8:
                    DisplayAllGoals(rewards);
                    Console.Write("Which reward do you want to claim? ");
                    int selectedReward = int.Parse(Console.ReadLine());
                    if (pointTotal < rewards[selectedReward - 1].GetPoints())
                    {
                        Console.WriteLine("You do not have enough points for this reward. Keep working hard and come back later (greedy man)!");
                    }
                    else
                    {
                        rewards[selectedReward - 1].CompleteGoal();
                    }
                    UpdateFile();
                    break;
                default:
                    Console.WriteLine("You entered an invalid option.");
                    break;
            }
        }
    }
}