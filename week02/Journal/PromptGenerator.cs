using System;

class PromptGenerators
{
   List<string> Prompts = new List<string>();

   public PromptGenerators()
   {
        Prompts.Add("Who was the most interesting person I interacted with today?\n");
        Prompts.Add("What was the best part of my day?\n");
        Prompts.Add("How did I see the hand of the Lord in my life today?\n");
        Prompts.Add("What was the strongest emotion I felt today?\n");
        Prompts.Add("If I had one thing I could do over today, what would it be?\n");
   }

   public void DisplayRandomPrompt()
   {
    Random RandomPrompt = new Random();

    int randomIndex = RandomPrompt.Next(Prompts.Count);

    Console.WriteLine(Prompts[randomIndex]);
   }


}