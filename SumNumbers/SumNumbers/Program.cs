namespace SumNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Please enter first number:  ");
            bool isFirstNum = int.TryParse(Console.ReadLine(), out int num1);
            Console.Write("Please enter second number:  ");
            bool isSecondNum = int.TryParse(Console.ReadLine(), out int num2);

            if (!isFirstNum || !isSecondNum)
            {
                Console.WriteLine("One of the inputs is not valid number.");

            }
            else
            {
                Console.WriteLine("Result: {0} + {1} = {2}", num1, num2, num1 + num2);
            }

            Console.ReadLine();
        }
    }
}
