namespace GuessNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int myNum = new Random().Next(1, 10 + 1);
            Console.Write("Guess the number I'm thinking of: ");
            bool isNum = int.TryParse(Console.ReadLine(), out int guess);

            if (myNum < guess)
            {
                Console.WriteLine("My number is smaller, guess again:");
            }
            else if (myNum > guess)
            {
                Console.WriteLine("My number is bigger, guess again:");
            }
            else if (myNum == guess)
            {
                Console.WriteLine("That's the right number!");
            }
            else if (isNum == false)
            {
                Console.WriteLine("My number is bigger, guess again:");
            }

            Console.ReadLine();
        }
    }
}

