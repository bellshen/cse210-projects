using System.Diagnostics;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;


    public Scripture(Reference Reference, string text)
    {
        _reference = Reference;
        var parts = text.Split(" ");
        _words = new List<Word>();
        for(int i = 0; i< parts.Length;i++)
        {
            _words.Add(new Word(parts[i]));
        }
    }
    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        int hidden = 0;

        while (hidden < numberToHide && _words.Any(w => !w.IsHidden()))
        {
            int index = random.Next(_words.Count);

            if (!_words[index].IsHidden())
            {
                _words[index].Hide();
                hidden++;
            }

        } 

    }
    public string GetDisplayText()
    {
        string text = string.Join(" ", _words.Select(w => w.GetDisplayText()));
        Console.WriteLine($"{_reference.GetDisplayText()} {text}");
        return text;
        
    }
    public bool IsCompletelyHidden()
    {
        return _words.All(w => w.IsHidden());
    }
    
}