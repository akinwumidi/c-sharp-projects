using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        
        int userInput = -1;
        do
        {
            Console.Write("Enter a number (0 to quit): ");
            
            string userResponse = Console.ReadLine();
            userInput = int.Parse(userResponse);
            
            // Only add the number to the list if it is not 0
            if (userInput != 0)
            {
                numbers.Add(userInput);
            }
        } while (userInput != 0);

        // Part 1: Compute the sum
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");

        // Part 2: Compute the average 
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        // Part 3: Find the max
        int maxNumber = numbers.Count > 0 ? numbers.Max() : 0; 

        // Console.WriteLine($"The max is: {maxNumber}");
        Console.WriteLine($"The max is: {maxNumber}");
    }
}