using System;
public class BreakActivity : Activity
{
    private List<string> _breaks = LoadFile("BreakPrompt.txt");
    public BreakActivity(string activityType, string activityDescription) : base(activityType, activityDescription){}
    public void BreakPrompt(int time)
    {
        int sessions = time / 20;
        for (int i = 0; i < sessions; i++)
        {
            Console.WriteLine(_breaks[random.Next(_breaks.Count() - 1)]);
            Pause(time / 2);
        }
    }
}