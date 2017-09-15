using System;

namespace Task9
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Throw a coin n times
            // Prompt user
            // Read user first input

            Console.Write("Please enter Number of throws:");

            string userInputN;
            int evaluatedNumberN;
            userInputN = Console.ReadLine();
            int.TryParse(userInputN, out evaluatedNumberN);

            // Confirm N
            // Console.WriteLine("You entered {0}", evaluatedNumberN);
            int randomNumber = 0;
            Random rnd = new Random();
            if (evaluatedNumberN > 1)
            {
                int loopCount = 0;
                int sumOutput = 0;
                int headsN = 0;
                int tailsN = 0;
                while (loopCount < evaluatedNumberN)
                {
                    loopCount++;
                    randomNumber = rnd.Next(2);
                    if (randomNumber == 0)
                    {
                        headsN++;
                    }
                    else
                    {

                        tailsN++;
                    }
                   
                    
                }
                Console.Write("Heads: {0} and Tails: {1}", headsN, tailsN);



            }
            else
            {

                Console.WriteLine("No throws!");
            }



            // Wait for user input
            Console.ReadKey();
        }
    }
}
