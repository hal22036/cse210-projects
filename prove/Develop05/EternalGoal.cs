using System;
public class EternalGoal : Goal
{
    public EternalGoal(string newGoal, string goalDescription, int points, int timesCompleted) : base(newGoal, goalDescription, points)
    {
        _timesCompleted = timesCompleted;
    }
    public EternalGoal(string newGoal, string goalDescription, int points) : base(newGoal, goalDescription, points)
    {
        _timesCompleted = 0;
    }
    public override void CompleteGoal()
    {
        Console.WriteLine("Great Job! Keep at this eternal goal and you will be blessed.");
        _timesCompleted += 1;
    }
    public override string DisplayGoal()
    {
        return $"[ ] {NewGoal} ({GoalDescription})";
    }
    public override string FormatToString()
    {
        return $"Eternal Goal|{NewGoal}|{GoalDescription}|{_points}|{_timesCompleted}";
    }
    public override int GetTimesCompleted()
    {
        return _timesCompleted;
    }
    public override int GetGoalAmount()
    {
        return 0;
    }    
}