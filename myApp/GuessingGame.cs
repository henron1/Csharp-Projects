using System;

namespace myApp
{
    class GuessingGame
    {
        static void Main(string[] args)
        {
            string secretWord = "magic word";
            string guess = "";
            int guessCount = 0;
            int guessLimit = 3;
            bool outOfGuesses = false;

            while(guess != secretWord && !outOfGuesses)
            {
                if (guessCount < guessLimit)
                {
                    Console.Write("Enter guess for the magic word: ");
                    guess = Console.ReadLine();
                    guessCount++;
                } 
                else 
                {
                    outOfGuesses = true;
                }
            }
            if(outOfGuesses)
            {
                Console.Write("You lose!");

            }
            else
            {
                Console.Write("You guess correctly!!");
            }
           

            Console.ReadLine();
        }
    }
}