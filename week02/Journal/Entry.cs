class Entry 
{
    public string Text {get; set;}
    public string Timestamp {get; set;}
    public string Prompt {get; set;}

    public Entry(string text, string prompt)
    {
        Text = text;
        Timestamp = DateTime.Now.ToString();
        Prompt = prompt;
    }

    public String GetFormattedEntry()
    {
        return $"Date: {Timestamp: yyyy-MM-dd HH:mm:ss} - Prompt: {Prompt} \n{Text}\n";
    }
}