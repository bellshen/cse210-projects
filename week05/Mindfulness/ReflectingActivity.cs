public class ReflectingActivity: Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless.",
        "Think of a time when you said something hurtful to others.",
        "Think of a time when you got help from others.",
        "Think of a time when you overcome your challenges."
    };
    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectingActivity() : base("Reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", 0)
    {

    }
    public void Run()
    {
        DisplayPrompt();
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();  //wait for pressing Enter or Return to continue.

        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write($"You may begin in: ");
        ShowCountDown(5);
        Console.Clear();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.Write(">");
            DisplayQuestions();
        }
    }

    //Get a random prompt to show
    private string GetRandomPrompt()
    {
        Random random = new Random();
        return _prompts[random.Next(_prompts.Count)];
    }

    //Get a random question about the prompt
    //*****Using noduplicated questions until using them all by removing the used question from the List<string> _question *****
    public string GetRandomQuestion()
    {
        if (_questions.Count == 0)
        {
            return "No more questions available.";
        }

        Random random = new Random();
        int index = random.Next(_questions.Count);
        string chosenQuestion = _questions[index];

        //remove the chosen question from the List, so the question won't repeat.
        _questions.RemoveAt(index);

        return chosenQuestion;
    }

    //Display the prompt
    public void DisplayPrompt()
    {
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        Console.WriteLine($"--- {GetRandomPrompt()} ---");
    }

    //Display questions about the prompt and get answers
    public void DisplayQuestions()
    {
        Console.Write(GetRandomQuestion());
        ShowSpinner(5);
        Console.WriteLine();
    }

}