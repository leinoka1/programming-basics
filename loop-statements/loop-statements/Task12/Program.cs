using System;

namespace Task12
{
    class Program
    {
        static void Main(string[] args)
        {
            // Throw a die 1000 times
            Random rnd = new Random();
            int maxSixofThousand = 0;
            
            int i = 0;
            for (i = 1; i <= 1000000; i++)
            {
                int sumSix = 0;
                int loopCount = 0;
                while (loopCount < 1000)
                {
                    int randomNumber = 0;
                    loopCount++;
                    randomNumber = rnd.Next(6);
                    randomNumber = randomNumber + 1;
                    // Console.WriteLine("{0}. {1}", loopCount, randomNumber);
                    if (randomNumber == 6)
                    {
                        sumSix++;
                    }
                    else
                    {
                    }
                }
                // Console.WriteLine("{0}", loopCount);
                // Console.WriteLine("Kuutonen arvottiin {0} kertaa", sumSix);
                if (maxSixofThousand < sumSix)
                {
                    maxSixofThousand = sumSix;
                    Console.WriteLine("MAX {0} kertaa", maxSixofThousand);
                }
                else
                {
                }
                // double propX = 0;
                // propX = ( 1.00/ 6.00);
                // Console.WriteLine("{0}", propX);
                
            }
            // Wait for user input
            Console.ReadKey();
        }
    }
}
