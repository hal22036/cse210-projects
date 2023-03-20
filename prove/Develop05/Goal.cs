using System;
public abstract class Goal
{
    protected string NewGoal { get; set; }
    protected string GoalDescription { get; set; }
    protected int _points;
    protected char _complete = ' ';
    protected int _timesCompleted;
    private List<string> _goals = new List<string>();
    public Goal(string newGoal, string goalDescription, int points)
    {
        NewGoal = newGoal;
        GoalDescription = goalDescription;
        _points = points;
    }
    public abstract string DisplayGoal();
    public abstract void CompleteGoal();
    public abstract string FormatToString();
    public abstract int GetTimesCompleted();
    public abstract int GetGoalAmount();
    public virtual int GetBonus()
    {
        return 0;
    }
    public void SetComplete(char complete)
    {
        _complete = complete;
    }
    public char GetComplete()
    {
        return _complete;
    }
    public void SetPoints(int points)
    {
        _points = points;
    }
    public virtual int GetPoints()
    {
        if (_timesCompleted < 1)
        {
            return 0;
        }
        return _points;
    }
}