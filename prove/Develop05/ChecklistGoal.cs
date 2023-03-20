using System;
public class ChecklistGoal : Goal
{
    private int _goalAmount;
    private int _bonus;
    public ChecklistGoal(string newGoal, string goalDescription, int points, int goalAmount, int bonus, int timesCompleted) : base(newGoal, goalDescription, points)
    {
        _goalAmount = goalAmount;
        _bonus = bonus;
        _timesCompleted = timesCompleted;
        if (_timesCompleted >= _goalAmount)
        {
            _complete = 'X';
        }
    }
    public ChecklistGoal(string newGoal, string goalDescription, int points, int goalAmount, int bonus) : base(newGoal, goalDescription, points)
    {
        _goalAmount = goalAmount;
        _bonus = bonus;
        _timesCompleted = 0;
    }
    public override void CompleteGoal()
    {
        _timesCompleted += 1;
        if (_timesCompleted == _goalAmount)
        {
            _complete = 'X';
            Console.WriteLine("Congratulations! You have completed your goal and received your bonus!");
        }
        Console.WriteLine("Congratulations on your progress. Keep working out at it!");
    }
    public override string DisplayGoal()
    {
        return $"[{GetComplete()}] {NewGoal} ({GoalDescription}) -Completed: {_timesCompleted}/{_goalAmount}";
    }
    public override string FormatToString()
    {
        return $"Checklist Goal|{NewGoal}|{GoalDescription}|{_points}|{_goalAmount}|{_bonus}|{_timesCompleted}";
    }
    public override int GetTimesCompleted()
    {
        return _timesCompleted;
    }
    public override int GetGoalAmount()
    {
        return _goalAmount;
    }
    public override int GetBonus()
    {
        return _bonus;
    }
    public override int GetPoints()
    {
        if (GetTimesCompleted() == GetGoalAmount())
        {
            return (_points * GetGoalAmount()) + GetBonus();
        }
        return _points * GetTimesCompleted();
    }
}