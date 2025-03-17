using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int userNumber;

        do
        {
            Console.WriteLine("Enter a number (0 to quit): ");
            string userResponce = Console.ReadLine();

            if (int.TryParse(userResponce, out userNumber) && userNumber != 0)
            {
                numbers.Add(userNumber);
            }
            else if (!int.TryParse(userResponce, out _))
            {
                Console.WriteLine("invalid input. Please enter valid number.");
            }

        } while (userNumber !=0);

        if (numbers.Count > 0)
        {
            int sum = numbers.Sum();
            float average = (float)numbers.Average();
            int max = numbers.Max();

            Console.WriteLine($"The sum is: {sum}");
            Console.WriteLine($"The average is: {average}");
            Console.WriteLine($"The max is: {max}");
        }
        else   
        {
            Console.WriteLine("No numbers were entred.");
        }
    }
}