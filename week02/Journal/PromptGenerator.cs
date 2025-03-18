using System;

public class PromptGenerator
{
    public List<String> _prompts;
    

    public  PromptGenerator()
    {
        _prompts = new List<string>()
        {
            "Who was the most interesting person i interacted with today?",
            "How did I see the hand of the lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
        };
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        return _prompts[random.Next(_prompts.Count)];
    }
    
}