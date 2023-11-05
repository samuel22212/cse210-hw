using System;
using System.Globalization;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    
    {  String playAgain = "y";
        do{
         int guessCounter = 1; 
        Console.WriteLine("Welcome to the guess the number game!");
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1,101); 
        int guess = 100000000;
        
        while (guess != number)
        {
            Console.WriteLine("Guess the magic number!");
            String guessInt = (Console.ReadLine());
            if (!Int32.TryParse(guessInt, out guess))
            {
                Console.WriteLine("");
            }
            
            if (guess < number)
            {
                Console.WriteLine("Higher");
                guessCounter ++; 
            }
            else if (guess > number)
            {
                Console.WriteLine("Lower");
                guessCounter ++; 
            }
            
        }
        if (guess == number){
            Console.WriteLine("Congratulations, you guessed the number!");
            Console.WriteLine($"You guessed the number in {guessCounter} guesses.");
            Console.WriteLine("Would you like to play again? (y) or (n)");
            playAgain = Console.ReadLine();
            


        }
        } while(playAgain=="y");
        Console.WriteLine("Thank you for playing");
    }
}