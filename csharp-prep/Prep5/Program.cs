using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int squaredNumber = SquareNumber(userNumber);
        DisplayResult(userName, squaredNumber);
    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program! ");
    }
    static string PromptUserName()
    {
        Console.WriteLine("Enter your name: ");
        string name = Console.ReadLine();
        return name;    
    }
    static int PromptUserNumber()
    {
        Console.WriteLine("What is your favorite number? ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }
    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;  
    }

    static void DisplayResult(string userName, int square)
    {
        Console.WriteLine($"{userName}, the square of you number is {square}");
    }
}