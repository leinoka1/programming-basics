﻿using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
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
                int sumOutput = 0;
                while (loopCount < evaluatedNumberN)
                {
                    loopCount++;
                    sumOutput = loopCount + sumOutput;
                }

                Console.WriteLine("Output: {0}", sumOutput);


            }
            else if (evaluatedNumberN < -1)
            {
                evaluatedNumberN = Math.Abs(evaluatedNumberN);
                int loopCount = 0;
                int sumOutput = 0;
                while (loopCount < evaluatedNumberN)
                {
                    loopCount++;
                    sumOutput = loopCount + sumOutput;
                }

                Console.WriteLine("Output: {0}", -sumOutput);
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
