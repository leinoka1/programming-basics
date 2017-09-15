
using System;



namespace Task7

{

    class Program

    {

        static void Main(string[] args)

        {

            // Multiplication table from 1 to 9

            Console.WriteLine("Multilication Table 1 to 9");

            int loopCount = 0;

            int loopCount2 = 0;

            int multiplicationX = 0;

            while (loopCount2 < 9)

            {

                loopCount2++;

                loopCount = 0;

                while (loopCount < 9)

                {

                    loopCount++;

                    multiplicationX = loopCount2 * loopCount;

                    Console.WriteLine("  {0} x {1}\t = {2}", loopCount2, loopCount, multiplicationX);

                }



            }







            // Wait for user input

            Console.ReadKey();

        }

    }

}