using System;
using System.Collections.Generic;

class PromptGenerators
{
   List<string> Prompts = new List<string>();

   public PromptGenerators()
   {
        Prompts.Add("Who was the most interesting person I interacted with today?");
        Prompts.Add("What was the best part of my day?");
        Prompts.Add("How did I see the hand of the Lord in my life today?");
        Prompts.Add("What was the strongest emotion I felt today?");
        Prompts.Add("If I had one thing I could do over today, what would it be?");
   }

   public string GetRandomPrompt()
   {
    Random RandomPrompt = new Random();

    int randomIndex = RandomPrompt.Next(Prompts.Count);

    return Prompts[randomIndex];
   }

   public void DisplayRandomPrompt()
   {
      string prompt = GetRandomPrompt();
      Console.WriteLine(prompt);
   }


}