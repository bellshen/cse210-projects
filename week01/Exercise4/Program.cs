using System;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");

        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        int enterNumber = -1;
        while (enterNumber != 0)
        {
            Console.WriteLine("Enter number:");
            enterNumber = int.Parse(Console.ReadLine());

            //add the number to the list if it is not 0
            if (enterNumber != 0)
            {
                numbers.Add(enterNumber);
            }
        }

        //1.Compute the sum, or total, of the numbers in the list.
        float sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is: {sum}");

        //2.Compute the average of the numbers in the list.
        float average = sum / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        //3.Find the maximum, or largest, number in the list.
        int max = numbers[0];
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The largest number is: {max}");




    }
}