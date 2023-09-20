using System;

class Program
{
    static void Main(string[] args)
    {
        String playAgain = "yes";
        while ( playAgain == "yes" ){
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);

            int guess = -1;

            int guesses = 0;

            while (guess != magicNumber)
            {
                Console.Write("What is the Mystic Numerical Entity? ");
                guess = int.Parse(Console.ReadLine());

                if (magicNumber > guess)
                {
                    Console.WriteLine("The Mystical Numerical Entity is higher!");
                    guesses++;
                }
                else if (magicNumber < guess)
                {
                    Console.WriteLine("The Mystical Numerical Entity is lower!");
                    guesses++;
                }
                else
                {
                    Console.WriteLine("You have guessed the Mystical Numerical Entity!");
                    Console.WriteLine("Number of Guesses: " + guesses.ToString());
                    Console.WriteLine("Would you like to play again? yes/no");
                    playAgain = Console.ReadLine();
                }
            }
        }
    } 
}