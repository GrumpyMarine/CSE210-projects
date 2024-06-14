using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello! What is the magic number? (Please choose between 1 thru 50)");
        // int number = int.Parse(Console.ReadLine());

        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1,51);
        
        int guess = -1;
        while(number != guess)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());
        
            if (number < guess)
            {
                Console.WriteLine("Lower");
            }
            else if(number > guess)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("Good job!");
            }
        }
        


    }
}