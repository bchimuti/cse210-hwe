using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage");
        if (int.TryParse(Console.ReadLine(), out int percent))
        {
            String letter = percent switch 
            {
                >= 90 => "A",
                >= 80 => "B",
                >= 70 => "C",
                >= 60 => "D",
                _ => "F"
            };
            Console.WriteLine($"Your grade id: {letter}");

            if (percent >= 70)
            Console.WriteLine("You passed");
        }
        else
        {
            Console.WriteLine("invalid input. Please enter a valid Number.");
        }
    }
}