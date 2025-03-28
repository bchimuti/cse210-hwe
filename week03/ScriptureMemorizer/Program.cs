using System;

class Program
{
    static void Main(string[] args)
    {
         var scripture = new Scripture("Proverbs 3:5-6", "Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight.");
        
        while (!scripture.AllHidden())
        {
            Console.Clear();
            scripture.Display();
            Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit.");
            if (Console.ReadLine().Trim().ToLower() == "quit") break;
            scripture.HideWords();
        }
        
        Console.Clear();
        scripture.Display();
        Console.WriteLine("\nAll words are hidden. Program ending.");
    }
}

class Scripture
{
    private string reference;
    private string[] words;
    private bool[] hidden;
    private Random random = new Random();

    public Scripture(string reference, string text)
    {
        this.reference = reference;
        words = text.Split(' ');
        hidden = new bool[words.Length];
    }

    public void Display()
    {
        Console.WriteLine(reference);
        Console.WriteLine(string.Join(" ", words.Select((w, i) => hidden[i] ? new string('_', w.Length) : w)));
    }

    public void HideWords()
    {
        var indices = Enumerable.Range(0, words.Length).Where(i => !hidden[i]).OrderBy(_ => random.Next()).Take(3);
        foreach (var i in indices) hidden[i] = true;
    }

    public bool AllHidden() => hidden.All(h => h);
}
