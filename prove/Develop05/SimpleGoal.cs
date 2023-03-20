using System;
public class SimpleGoal : Goal
{
    public SimpleGoal(string newGoal, string goalDescription, int points, int timesCompleted = 0) : base(newGoal, goalDescription, points)
    {
        _timesCompleted = timesCompleted;
        if (_timesCompleted > 0)
        {
            _complete = 'X';
        }
    }
    public override string DisplayGoal()
    {
        return $"[{GetComplete()}] {NewGoal} ({GoalDescription})";
    }
    public override void CompleteGoal()
    {
        if (_timesCompleted == 1)
        {
            Console.WriteLine("You have already completed this goal.");
        }
        else
        {
            _timesCompleted = 1;
            _complete = 'X';
            Console.WriteLine("Congratulations you've just completed your goal!!");
        }

    }
    public override string FormatToString()
    {
        return $"Simple Goal|{NewGoal}|{GoalDescription}|{_points}|{_timesCompleted}";
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