public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;

    public void Display()
    {
        //get Datetime and convert it to string
        DateTime today = DateTime.Today;
        _date = today.ToString("yyyy-MM-dd");

        PromptGenerator prompt = new PromptGenerator();
        _promptText = prompt.GetRandomPrompt();

        Console.Write($"{_promptText}");

        Console.Write(" ");
        _entryText = Console.ReadLine();

    }

}
