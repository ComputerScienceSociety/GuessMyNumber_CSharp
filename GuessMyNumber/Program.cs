using System;

namespace GuessMyNumber
{
	class Program
	{

		static void Main(string[] args)
		{
			//create variables
			int targetNumber = 0;
			int guess = -1;
			int noOfGuesses = 0;

			//Greeting message
			Console.WriteLine("Welcome to the guess my number game \nI am thinking of a number...\n");

			//store random number in public variable
			targetNumber = ThinkOfNewNumber();

			//run loop until correct number has been guessed
			while(guess != targetNumber)
			{
				Console.WriteLine("Guess number " + (noOfGuesses += 1));
				Int32.TryParse(Console.ReadLine(), out guess);

				bool guessIsValid = IsGuessValid(guess);

				if (!guessIsValid)
				{
					break;
				}

				IsNumberCorrect(guess, targetNumber);
			}
			Console.WriteLine("Thanks for playing!");

			Console.ReadKey();
		}

		static int ThinkOfNewNumber()
		{
			Random rnd = new Random();
			return rnd.Next(100);
		}

		static bool IsGuessValid(int myGuess)
		{
			if(myGuess > 100)
			{
				Console.WriteLine("Guess must be less than or equal to 100!\n");
				return false;
			}
			else if(myGuess < 0)
			{
				Console.WriteLine("Guess must be greater than or equal to 0!\n");
				return false;
			}

			return true;
		}


		static void IsNumberCorrect(int myGuess, int myTarget)
		{
			if(myGuess == myTarget)
			{
				Console.WriteLine("Congratulations, you guessed the number correctly\n");
			}
			else if(myGuess > myTarget && myGuess <= 100)
			{
				Console.WriteLine("Too high! Try again!\n");
			}
			else if (myGuess < myTarget && myGuess >= 0)
			{
				Console.WriteLine("Too Low! Try again!\n");
			}
		}
	}
}
