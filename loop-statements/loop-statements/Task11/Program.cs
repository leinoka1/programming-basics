using System;

namespace Task11
{
    class Program
    {
        static void Main(string[] args)
        {
            // Throw a die 1000 times

            int loopCount = 0;
            int randomNumber = 0;
            Random rnd = new Random();
            int sumSix= 0;
            while (loopCount < 1000)
            {
                loopCount++;
                randomNumber = rnd.Next(6);
                randomNumber = randomNumber + 1;

                Console.WriteLine("{0}. {1}", loopCount, randomNumber);
                if (randomNumber == 6)
                    {
                        sumSix++;
                    }
                    else
                    {
                    }
            }
            // Console.WriteLine("{0}", loopCount);
            Console.WriteLine("Kuutonen arvottiin {0} kertaa", sumSix);
            // double propX = 0;
            // propX = ( 1.00/ 6.00);
            // Console.WriteLine("{0}", propX);
                            
            // Wait for user input
            Console.ReadKey();
        }
    }
}
