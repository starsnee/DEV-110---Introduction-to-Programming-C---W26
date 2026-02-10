namespace GuessTheNumber;

public class Program
{
    public static void Main(string[] args)
    {
        Random randomNum = new Random();

        int max = ReadIntInRange("Enter a max value (10-100): ", 10, 100);
        int rounds = ReadIntInRange("How many rounds? (1-3): ", 1, 3);

        Console.WriteLine("=== Guess the Number: Loop Trio ===\n");

        for (int round = 1; round <= rounds; round++)
        {
            Console.WriteLine($"\nRound {round} of {rounds}");
            int secret = randomNum.Next(1, max + 1);
            int guess = 0;
            int guessCount = 0;

            while (guess != secret)
        {
            Console.WriteLine($"Guess a number (1-{max}): ");
            int.TryParse(Console.ReadLine(), out guess);
            if (guess < secret)
            {
                Console.WriteLine("Too low.");
                guessCount++;
            }
            else if (guess > secret)
            {
                Console.WriteLine("Too high.");
                guessCount++;
            }
            else
            {
                Console.WriteLine($"Correct! You got it in {guessCount} guesses.");
            }
        }
        }

        static int ReadIntInRange(string prompt, int min, int max)
        {
            int value;
            bool isValid;

            do
            {
                Console.WriteLine(prompt);
                string input = Console.ReadLine();
                isValid = int.TryParse(input, out value);
                if (!isValid || value < min || value > max)
                {
                    Console.WriteLine($"Invalid input. Please enter a number between {min} and {max}.");
                }
            }
            while (!isValid || value < min || value > max);
            return value;
        }

        System.Console.WriteLine("Thanks for playing!");
    }
}
