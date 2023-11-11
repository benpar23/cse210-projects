using System;

class Program
{
    static void Main(string[] args)
    {
        PromptGenerator _prompt = new PromptGenerator();

        Console.WriteLine(_prompt.GetRandomPrompt());
    }
}