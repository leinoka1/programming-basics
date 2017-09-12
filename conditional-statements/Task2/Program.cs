using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt user
            Console.Write("Please enter number");

            // Read user input
            string userInput;
            userInput = Console.ReadLine();

            // Evaluate user input

            int evaluatedNumber;
            // evaluatedNumber = int.Parse(userInput);
            int.TryParse(userInput, out evaluatedNumber);

            Console.WriteLine("User input was: {0} : integer: {1}", userInput, evaluatedNumber);
            // Console.WriteLine("user input was: " + userInput);


            if (evaluatedNumber % 2 == 0)
            {
                Console.WriteLine("Number {0} is even", evaluatedNumber);
            }

            else
            {
                Console.WriteLine("Number {0} is odd", evaluatedNumber);
            }

            // Wait for user input
            Console.ReadKey();
        }
    }
}
