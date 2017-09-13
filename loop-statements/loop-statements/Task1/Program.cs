using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
                {
                // Prompt user
                // Read user first input
                
                Console.Write("Input:");

                string userInputN;
                int evaluatedNumberN;
                userInputN = Console.ReadLine();
                int.TryParse(userInputN, out evaluatedNumberN);

                // Confirm N
                Console.WriteLine("You entered {0}", evaluatedNumberN);
                if (evaluatedNumberN > 1)
                {
                    int loopCount = 0;
                    long multiplationOutput = 1;
                    while (loopCount < evaluatedNumberN)
                    {
                        loopCount++;
                        multiplationOutput = loopCount * multiplationOutput;
                    }

                    Console.WriteLine("Output: {0}", multiplationOutput);


                }
                else
                {

                    Console.WriteLine("Määrittelemätön");
                }
                    

                
                // Wait for user input
                Console.ReadKey();
                }

        }
    }
}
