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

            while(guess != secretWord)
            {
                Console.Write("Enter guess for the magic word: ");
                guess = Console.ReadLine();
            }
            Console.Write("You guess correctly!!");
            Console.ReadLine();
        }
    }
}