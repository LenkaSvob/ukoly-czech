namespace Asterisks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter amount of stars: ");


            bool isNum = int.TryParse(Console.ReadLine(), out int starsNum);
            if (isNum == true)
            {
                for (int i = 0; i < starsNum; i++)
                {
                    Console.Write("*");
                }
            }
            else 
            {
                Console.WriteLine("Enter a valid number.");
            }

            Console.ReadLine();

        }
    }
}
