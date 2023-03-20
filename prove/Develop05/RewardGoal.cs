using System;
public class RewardGoal : Goal
{
    public RewardGoal(string reward, string rewardDescription, int rewardPoints, int timesCompleted = 0) : base(reward, rewardDescription, rewardPoints)
    {
        _timesCompleted = timesCompleted;
        if (_timesCompleted > 0)
        {
            _complete = 'X';
        }
    }
    public override string DisplayGoal()
    {
        return $"[{GetComplete()}] {NewGoal} ({GoalDescription}) Needed Points: {_points}";
    }
    public override void CompleteGoal()
    {
        Console.WriteLine($"You've collected the {NewGoal} reward!!!");
        _timesCompleted++;
        _complete = 'X';
    }
    public override string FormatToString()
    {
        return $"Reward|{NewGoal}|{GoalDescription}|{_points}|{_timesCompleted}";
    }
    public override int GetTimesCompleted()
    {
        return _timesCompleted;
    }
    public override int GetGoalAmount()
    {
        return 0;
    }
    public override int GetBonus()
    {
        return 0;
    }
    public override int GetPoints()
    {
        return _points;
    }
}