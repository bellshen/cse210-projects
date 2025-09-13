// Don't forget to put this at the top, so C# knows where to find the StreamWriter class
using System;
using System.IO;
using System.Collections.Generic;

public class Journal
{

    public List<Entry> _entries = new List<Entry>();
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }
    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No entries found. Please try again.");
        }
        else
        {
            foreach (Entry entry in _entries)
            {
                Console.WriteLine($"Date: {entry._date} Prompt: {entry._promptText}");
                Console.WriteLine($"{entry._entryText}");
            }
        }
        
    }
    public void SaveToFile(string file)
    {
        Console.WriteLine("Saving to file......");

        using (StreamWriter outputFile = new StreamWriter(file))
        {

            // You can use the $ and include variables just like with Console.WriteLine
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}: {entry._promptText} {entry._entryText}");
            }

        }
        Console.WriteLine($"Saved {_entries.Count} entries to {file}");
    }
    public void LoadFromFile(string file)
    {
        Console.WriteLine("Loading from file......");


        if (File.Exists(file))
        {
            string[] lines = System.IO.File.ReadAllLines(file);

            foreach (string line in lines)
            {
                string[] parts = line.Split(",");

                if (parts.Length >= 3)
                {
                    string dateTime = parts[0];
                    string promptText = parts[1];
                    string entryText = string.Join(",", parts, 2, parts.Length - 2);

                    Entry entry = new Entry();
                    entry._date = dateTime;
                    entry._promptText = promptText;
                    entry._entryText = entryText;

                    _entries.Add(entry);

                }
            }
            Console.WriteLine($"Loaded {_entries.Count} entries from {file}");

        }
        else
        {
            Console.WriteLine("File not found.");
        }

        
    }
}