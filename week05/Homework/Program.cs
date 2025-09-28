using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Homework Project.");

        Assignment a1 = new Assignment("Allan", "Gospel of Jesus Christ");
        Console.WriteLine(a1.GetSummary());

        MathAssignment a2 = new MathAssignment("Julia", "Chapter 01","P103-180", "Intersections");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworkList());

        WritingAssignment a3 = new WritingAssignment("Ether", "History of War","The Cause of Second World War II in Asia Area");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInformation());

    }
}