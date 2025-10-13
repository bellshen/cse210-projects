using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Hello World! This is the ExerciseTracking Project.");

        List<Activity> activities = new List<Activity>();

        Running r1 = new Running("9 Sep 2025", 40, 5.5);
        activities.Add(r1);

        Running r2 = new Running("10 Sep 2025", 50, 6.8);
        activities.Add(r2);

        Cycling c1 = new Cycling("12 Sep 2025", 60, 13.8);
        activities.Add(c1);

        Cycling c2 = new Cycling("15 Sep 2025", 90, 24.5);
        activities.Add(c2);

        Swimming s1 = new Swimming("20 Sep 2025", 35, 10);
        activities.Add(s1);

        foreach(Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }

    }
}