using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int guess;
        do
        {
            Console.WriteLine("What is your guess? (1-100)");
            string answer = Console.ReadLine();
            guess = int.Parse(answer);

            if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }

        } while (guess != magicNumber);

        Console.WriteLine("You guess it!");
            
             
        


    }
}