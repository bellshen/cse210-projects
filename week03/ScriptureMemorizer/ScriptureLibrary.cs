using System;
using System.Collections.Generic;

public class ScriptureLibrary
{
    private Dictionary<Reference, string> _scriptures;
    private Random _random = new Random();

    public ScriptureLibrary()
    {
        _scriptures = new Dictionary<Reference, string>()
        {
           { new Reference("Matthew", 5, 9), "Blessed are the peacemakers: for they shall be called the children of God." },
           { new Reference("John", 3, 16),"For God so loved the world, that he gave his only Son, that whoever believes in him should not perish but have eternal life."},
           { new Reference("Proverbs", 3, 5,6),"Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight." }
        };

    }
    public Scripture GetRandomScripture()
    {
        int index = _random.Next(_scriptures.Count);
        Reference reference = _scriptures.Keys.ElementAt(index);
        string text = _scriptures[reference];
        return new Scripture(reference, text);

    }

}