using System;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt user
            // Read user first input
            // Square root 1 to 10
            Console.WriteLine("Number Square root");
            int loopCount = 0;
            double squareRoot = 0;
            while (loopCount < 10)
                {
                    loopCount++;
                    squareRoot = Math.Sqrt(loopCount);
                    Console.WriteLine("  {0}\t{1:N2}", loopCount, squareRoot);
                }
                          
            // Wait for user input
            Console.ReadKey();
        }
    }
}
