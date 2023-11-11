using System.Collections.Generic;
public class PromptGenerator
{
    public List<string> _prompts = new List<string> {"Who was the most interesting person I interacted with today?", "What was the best part of my day?", "What was the strongest emotion I felt today?", "How did I see the hand of the Lord in my life today?", "If I had one thing I could do over today, what would it be?"};

    public string GetRandomPrompt()
    {
        var random = new Random();

        int index = random.Next(_prompts.Count);

        return _prompts[index];
    }
}