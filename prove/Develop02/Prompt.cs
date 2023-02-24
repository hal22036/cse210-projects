using System;

public class Prompt
{
    static List<string> questions = new List<string>()
            {
            "What brings you joy?",
            "What was the best thing that happened to you today?",
            "What is something that made you laugh today?",
            "What steps did you take today towards a goal you’re working on?",
            "Who made your day better today? How can you pay that feeling forward?",
            "What made today unique?",
            "What is one thing you want to remember from today?",
            "When did you feel most authentically yourself today?",
            "How can you make tomorrow (even) better than today?",
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "What are three things you’re grateful for today?",
            "What’s something that’s working well in your life right now?",
            "What’s a simple pleasure in your life that you are thankful for?",
            "What musician or song are you grateful for? Why?",
            "Look around your room. What are some things that make you grateful?",
            "What person in your life are you most thankful for?",
            "What tradition in your life makes you feel grateful?",
            "What experiences have you had that you are grateful for?",
            };
    static Random random = new Random();
    public string _prompt = questions[random.Next(0, questions.Count - 1)];

}
