using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomeMessage();

        string name = PromptUserInput("Please enter your name");
        int number = PromptNumberImput("Please enetr your favorite number: ");

        int squared = CalculateSquare(number);
        ShowResult(name, squared);
    }
    static void DisplayWelcomeMessage() => Console.WriteLine("Welcome to the program");

    static string PromptUserInput(string message)
    {
        Console.Write(message);
        return Console.ReadLine();
    }

    static int PromptNumberImput(string message)
    {
        Console.Write(message);
        return int.TryParse(Console.ReadLine(), out int num)? num : 0;
    }

    static int CalculateSquare(int num) => num * num;

    static void ShowResult(string name, int squared) =>
        Console.WriteLine($"{name}, the square of your number is {squared}");
}