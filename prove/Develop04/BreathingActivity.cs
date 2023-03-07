using System;
public class BreathingActivity : Activity
{
    public BreathingActivity(string activityType, string activityDescription) : base(activityType, activityDescription){}
    public void BreathingPrompt(int secondResponse)
    {
        int number = (secondResponse / 10);
        for (int i = number; i >= 1; i--)
        {
            Console.Write("\n\nBreathe in... ");
            CountDown(4);
            Console.WriteLine("");
            Console.Write("Now Breathe out... ");
            CountDown(6);
        }

    }
}