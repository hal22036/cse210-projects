using System;
public class ReflectionActivity : Activity
{
    private List<string> _prompts = LoadFile("ReflectionPrompt.txt");
    private List<string> _questions = LoadFile("Questions.txt");
    public ReflectionActivity(string activityType, string activityDescription) : base(activityType, activityDescription){}
    public void ReflectionPrompt(int time)
    {
        int sessions = time / 20;
        for (int i = 0; i < sessions; i++)
        {
            Console.WriteLine(_prompts[random.Next(_prompts.Count())]);
            Pause(time / 2);
            Console.WriteLine(_questions[random.Next(_questions.Count())]);
            Pause(time / 2);
        }
    }
}