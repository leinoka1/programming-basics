using System;

namespace Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            // Fifty Random Numbers
            // 5 numbers per line
            // Random rnd = new Random();  Luodaan uusi ilmentymä rnd oliosta Random.
            // rnd.NextDouble(); metodi arpoo luvun 0...1 väliltä
            // rnd.Next(100); metodi arpoo kokonaisluvun 0 ja 100 väliltä ]0...100[

            Console.WriteLine("Fifty random numbers");
            int loopCount = 0;
            int loopCount2 = 0;
            int randomNumber = 0;
            Random rnd = new Random();
            while (loopCount2 < 10)
            {
                loopCount2++;
                loopCount = 0;
                
                while (loopCount < 5)
                {
                    loopCount++;
                    //randomNumber = 0;
                    
                    randomNumber = rnd.Next(50);
                    Console.Write("{0:D2},", randomNumber);
                }

                Console.Write("\n");
            }



            // Wait for user input
            Console.ReadKey();
        }
    }
}
