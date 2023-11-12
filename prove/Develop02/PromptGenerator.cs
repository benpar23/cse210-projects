using System.Collections.Generic;
public class PromptGenerator
{
    public List<string> _prompts = new List<string> {"Who was the most interesting person I interacted with today?", "What was the best part of my day?", "Why did you feel like you wanted to write in your journal today?", "How did I see the hand of the Lord in my life today?", "What was your favourite meal you had today?", "What was the funniest thing that happened today?", "Who did you feel like you emulated in your actions today?", "Who did you talk with the most today?"};

    public string GetRandomPrompt()
    {
        var random = new Random();

        int index = random.Next(_prompts.Count);

        return _prompts[index];
    }
}