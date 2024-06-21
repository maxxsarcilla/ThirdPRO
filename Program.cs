using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 25, 75, 10 };

        int highest = numbers[0];
        int lowest = numbers[0];

        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] > highest)
            {
                highest = numbers[i];
            }
            if (numbers[i] < lowest)
            {
                lowest = numbers[i];
            }
        }

        Console.WriteLine($"The Highest Number: {highest}");
        Console.WriteLine($"The Lowest Number: {lowest}");
    }
}

