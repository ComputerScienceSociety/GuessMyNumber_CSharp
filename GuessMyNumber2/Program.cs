using System;

namespace GuessMyNumber
{
	class Program
	{
		static int targetNumber;
		static int guess;

		static void Main(string[] args)
		{
			//Greeting message
			Console.WriteLine("Welcome to the guess my number game \nI am thinking of a number...\n");

			//store random number in public variable
			targetNumber = ThinkOfNewNumber();

			//Main game logic runs in this loop
			int noOfGuesses = 0;
			while (guess != targetNumber)
			{
				Console.WriteLine("Guess number " + (noOfGuesses += 1));
				Int32.TryParse(Console.ReadLine(), out guess);

				bool guessIsValid = IsGuessValid();

				if (!guessIsValid)
				{
					break;
				}

				IsNumberCorrect();
			}
			Console.WriteLine("Thanks for playing!");

			//This stops the game exiting straight away when run in debug mode
			Console.ReadKey();
		}


		static int ThinkOfNewNumber()
		{
			Random rnd = new Random();
			return rnd.Next(100);
		}


		static bool IsGuessValid()
		{
			if (guess > 100)
			{
				Console.WriteLine("Guess must be less than or equal to 100!\n");
				return false;
			}
			else if (guess < 0)
			{
				Console.WriteLine("Guess must be greater than or equal to 0!\n");
				return false;
			}

			return true;
		}


		static void IsNumberCorrect()
		{
			if (guess == targetNumber)
			{
				Console.WriteLine("Congratulations, you guessed the number correctly\n");
			}
			else if (guess > targetNumber && guess <= 100)
			{
				Console.WriteLine("Too high! Try again!\n");
			}
			else if (guess < targetNumber && guess >= 0)
			{
				Console.WriteLine("Too Low! Try again!\n");
			}
		}
	}
}
