public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing","This activity will help you relax by walking through breathing in and out slowly. Clear your mind and focus on your breathing.",0)
    {
    }
    public void Run()
    {
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("Breathe in ...");
            ShowCountDown(5);
            Console.WriteLine();
            Console.Write("Now breathe out...");
            ShowCountDown(5);
            Console.WriteLine();
        }

    }
}