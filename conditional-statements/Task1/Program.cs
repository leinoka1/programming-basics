using System;

namespace Task1
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
            
            if (evaluatedNumber > 0)
            {
                Console.WriteLine("Number {0} is positive", evaluatedNumber);
            }
                             
            else if (evaluatedNumber < 0)
            {
                Console.WriteLine("Number {0} is negative", evaluatedNumber);
            }
            
            else
            {
                Console.WriteLine("Number {0} equals 0", evaluatedNumber);
            }

            // Wait for user input
            Console.ReadKey();
        }
    }
}
