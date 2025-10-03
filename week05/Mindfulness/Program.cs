using System;
using System.Xml.Serialization;

//**** In ReflectingActivity.cs, I can get noduplicated questions in GetRandomQuestion() by removing the used question from the List<string> _question ****
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Mindfulness Project.");


        bool running = true;
        while (running)
        {
            Console.WriteLine("Mindfulness Program");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu:(1-4): ");
            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                BreathingActivity breathingActivity = new BreathingActivity();
                breathingActivity.DisplayStartingMessage();
                breathingActivity.Run();
                breathingActivity.DisplayEndingMessage();
            }
            else if (choice == 2)
            {
                ReflectingActivity reflectingActivity = new ReflectingActivity();
                reflectingActivity.DisplayStartingMessage();
                reflectingActivity.Run();
                reflectingActivity.DisplayEndingMessage();
            }

            else if (choice == 3)
            {
                ListingActivity listingActivity = new ListingActivity();
                listingActivity.DisplayStartingMessage();
                listingActivity.Run();
                listingActivity.DisplayEndingMessage();
            }

            else if (choice == 4)
            {
                Console.WriteLine("Thank you for using the Mindfulness Program.");
                running = false;
                break;
            }
            else
            {
                Console.WriteLine("Invalid input, please enter 1-4!");
            }
        }
    }
}