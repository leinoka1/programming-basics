using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sum of serie for odd and even numbers
            // Accepts also negative númbers
            // Firts input
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
                int sumOutputEven = 0;
                int sumOutputOdd = 0;
                while (loopCount < evaluatedNumberN)
                {
                    loopCount++;
                    if (loopCount % 2 == 0)
                    {
                        sumOutputEven = loopCount + sumOutputEven;

                    }

                    else
                    {
                        sumOutputOdd = loopCount + sumOutputOdd;

                    }

                }

                Console.WriteLine("Output: Parittomien summa = {0}, Parillisten summa = {1}", sumOutputOdd, sumOutputEven);


            }
            else if (evaluatedNumberN < -1)
            {
                evaluatedNumberN = Math.Abs(evaluatedNumberN);
                int loopCount = 0;
                int sumOutputEven = 0;
                int sumOutputOdd = 0;
                while (loopCount < evaluatedNumberN)
                {
                    loopCount++;
                    if (loopCount % 2 == 0)
                    {
                        sumOutputEven = loopCount + sumOutputEven;

                    }

                    else
                    {
                        sumOutputOdd = loopCount + sumOutputOdd;

                    }

                }
                Console.WriteLine("Output: Parittomien summa = {0}, Parillisten summa = {1}", -sumOutputOdd, -sumOutputEven);
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
