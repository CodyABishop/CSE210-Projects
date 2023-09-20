using System;

class Program
{
    static void Main(string[] args)
    {
        StartUpMessage();

        string userName=PromptUserName();
        int userNumber = PromptUserNumber();
        int numbersquared = SquareNumber(userNumber);
        DisplayOutcome(userName, numbersquared);
    }
    static void StartUpMessage()
    {
        Console.WriteLine("Welcome!");
    }
    static string PromptUserName()
    {
        Console.Write("Please provide your User ID: ");
        string name = Console.ReadLine();
        return name;
    }
    static int PromptUserNumber()
    {
        Console.Write("Please provide a number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }
    static int SquareNumber(int number)
    {
        int square= number * number;
        return square;
    }
    static void DisplayOutcome(string name, int square)
    {
        Console.WriteLine($"{name}, your number squared is {square}");
    }
}