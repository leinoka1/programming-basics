using System;

namespace Task10
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tipping
            // 13 games
            int loopCount = 0;
            Random rnd = new Random();
            double randomNumber = 0;
            while (loopCount < 13)
            {
                loopCount++;
                randomNumber = rnd.NextDouble();
                if (randomNumber < 0.4)
                {
                    Console.WriteLine("{0}. 1", loopCount);
                }
                else if (randomNumber < 0.6)
                {

                    Console.WriteLine("{0}. X", loopCount);
                }
                else
                {
                    Console.WriteLine("{0}. 2", loopCount);
                }
                                           
            }

            // Wait for user input
            Console.ReadKey();
        }
    }
}
