using System;
using System.Collections.Generic;
using System.IO;

class Entry
{
    public string Date { get; }
    public string Prompt { get; }
    public string Response { get; }

    public Entry(string prompt, string response) 
        => (Date, Prompt, Response) = (DateTime.Now.ToString("yyyy-MM-dd"), prompt, response);

    public Entry(string date, string prompt, string response) 
        => (Date, Prompt, Response) = (date, prompt, response); // New constructor for loading

    public void Display() => Console.WriteLine($"Date: {Date}\nPrompt: {Prompt}\nResponse: {Response}\n");

    public override string ToString() => $"{Date}|{Prompt}|{Response}";

    public static Entry FromString(string data)
    {
        var parts = data.Split('|');
        return new Entry(parts[0], parts[1], parts[2]); // Using the new constructor
    }
}

class Journal
{
    private List<Entry> entries = new();
    private static readonly List<string> prompts = new()
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };

    public void AddEntry()
    {
        string prompt = prompts[new Random().Next(prompts.Count)];
        Console.WriteLine($"\nPrompt: {prompt}\nYour Response: ");
        entries.Add(new Entry(prompt, Console.ReadLine()));
        Console.WriteLine("Entry added!\n");
    }

    public void DisplayEntries() => entries.ForEach(e => e.Display());

    public void SaveToFile()
    {
        Console.Write("Enter filename: ");
        File.WriteAllLines(Console.ReadLine(), entries.ConvertAll(e => e.ToString()));
        Console.WriteLine("Journal saved!\n");
    }

    public void LoadFromFile()
    {
        Console.Write("Enter filename: ");
        string filename = Console.ReadLine();
        if (File.Exists(filename))
        {
            entries = new List<Entry>(Array.ConvertAll(File.ReadAllLines(filename), Entry.FromString));
            Console.WriteLine("Journal loaded!\n");
        }
        else Console.WriteLine("File not found!\n");
    }
}

class Program
{
    static void Main()
    {
        Journal journal = new();
        string choice;
        do
        {
            Console.WriteLine("\n1. Write Entry  2. View Journal  3. Save  4. Load  5. Exit");
            choice = Console.ReadLine();
            switch (choice)
            {
                case "1": journal.AddEntry(); break;
                case "2": journal.DisplayEntries(); break;
                case "3": journal.SaveToFile(); break;
                case "4": journal.LoadFromFile(); break;
                case "5": Console.WriteLine("Goodbye!"); break;
                default: Console.WriteLine("Invalid choice. Try again."); break;
            }
        } while (choice != "5");
    }
}
