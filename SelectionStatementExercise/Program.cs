namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            bool continueGame = true;

            int max = 1000;
            int answer = random.Next(1, max);

            Console.WriteLine($"I'm thinking of a number between 1 and {max}.");
            Console.WriteLine($"Can you guess what number it is?");

            do
            {
                Console.Write("\n❔  Enter your guess: ");
                int userInput = int.Parse(Console.ReadLine());

                if (userInput >= 1 && userInput < max)
                {
                    continueGame = GameOver(userInput, answer);
                }
                else
                {
                    Console.WriteLine("Invalid input, try again");
                }
            } while (continueGame == true);
        }

        public static bool GameOver(int userInput, int answer)
        {
            bool continueGame;

            if (userInput < answer)
            {
                Console.WriteLine($"⬇️   Too low! Try again.");
                continueGame = true;
            }
            else if (userInput > answer)
            {
                Console.WriteLine($"⬆️   Too high! Try again.");
                continueGame = true;
            }
            else
            {
                Console.WriteLine("✅  You guess it!");
                continueGame = false;
            }

            return continueGame;
        }
    }
}
