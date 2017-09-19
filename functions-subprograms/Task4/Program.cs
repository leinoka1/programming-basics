using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {           
            Console.WriteLine("Max number was {0}", MaxOfTenNumbers());
            Console.ReadKey();
        }
        static int MaxOfTenNumbers ()
        {
            int i = 0;
            int j = 0;
            int k = 0;
            int numberN;
            int maxNumber = 0;
            string numberString;
            string outputString = "";
            Console.WriteLine("Give ten numbers");
            while (i <= 9)
            {
                Console.Write("{0}.", i+1);
                numberString = Console.ReadLine();
                int.TryParse(numberString, out numberN);
                if (numberN > 0)
                {
                    i++;
                    outputString = outputString + " "+ numberString;
                    if (numberN > maxNumber)
                    {
                        maxNumber = numberN;
                        j++;
                        k = i;
                    }    
                }   
                else
                {
                    Console.WriteLine("Wrong input, please give a positive number");
                }
            }
            Console.WriteLine("You entered following positive numbers {0}", outputString);
            Console.Write("Max number was {0}. ",k);
            return maxNumber;
        }
    }
}