using System;
using System.Collections.Generic;

//I added ScriptureLibrary.cs to get random scripture, 
//it will be convinient for me add more scriptures.

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");
        Console.Clear();
        ScriptureLibrary library = new ScriptureLibrary();
        Scripture scripture = library.GetRandomScripture();

        while (scripture.IsCompletelyHidden() == false)
        {
            scripture.GetDisplayText();
            Console.Write("Please Press Enter to hide more words or type 'quit' to end the program. ");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords(2);
            Console.Clear();

        }
        Console.WriteLine("End of Program.");

    }

}