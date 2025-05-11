using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int n;

        // Input validation
        while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
        {
            Console.Write("Please enter a positive integer: ");
        }

        // Create a list of numbers from 1 to n
        List<int> numbers = new List<int>();
        for (int i = 1; i <= n; i++)
        {
            numbers.Add(i);
        }

        // Create a Random object
        Random rand = new Random();

        // Print numbers in random order without repetition
        Console.WriteLine("Random numbers without repetition:");
        while (numbers.Count > 0)
        {
            int index = rand.Next(numbers.Count);
            Console.Write(numbers[index] + " ");
            numbers.RemoveAt(index);
        }

        Console.WriteLine("\nEnd of program.");
    }
}
