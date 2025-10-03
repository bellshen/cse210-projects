public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"

    };

    public ListingActivity():base("Listing","This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.",0)
    {
    }
    public void Run()
    {
        GetRandomPrompt();
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.WriteLine();
        List<string> responses = GetListFromUser();
        _count = responses.Count;
        Console.WriteLine($"You listed {_count} items.");
        ShowSpinner(4);
    }

    //Get a random prompt
    public void GetRandomPrompt()
    {
        Console.WriteLine("List as many responses you can to the following prompt:");
        Random random = new Random();
        Console.WriteLine($" --- {_prompts[random.Next(_prompts.Count)]} ---");
    }

    //Get a list of responses from the user
    public List<string> GetListFromUser()
    {
        List<string> userResponse = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.Write(">");
            string s = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(s))
            {
                userResponse.Add(s);
            }
        }
        
        return userResponse;
    }
}