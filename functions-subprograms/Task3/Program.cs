using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            string number;
            int minimiumNumber, maximiumNumber;
            minimiumNumber = 5;
            maximiumNumber = 10;

            Console.Write("Input number between {0} and {1}: ", minimiumNumber, maximiumNumber);
            number = Console.ReadLine();
            IsBetweenTwoNumbers(minimiumNumber, maximiumNumber, number);
            Console.ReadKey();
        }
       static int IsBetweenTwoNumbers(int minNumber, int maxNumber, string numberString)
        {
            int numberN;
            bool isNumeric = int.TryParse(numberString, out numberN);
            while (isNumeric == false)
            {
                Console.WriteLine("Given number {0} is not a number. Please enter a number: ", numberString);
                numberString = Console.ReadLine();
                Console.WriteLine("annoit {0}", numberString);
                isNumeric = int.TryParse(numberString, out numberN);
            }
            int.TryParse(numberString, out numberN);
            while (numberN >= maxNumber || numberN <= minNumber)
            {
                Console.Write("Input number {0} is not between and {1} - {2}. Please enter again: ", numberN, minNumber, maxNumber);
                numberString = Console.ReadLine();
                int.TryParse(numberString, out numberN);
            }
            Console.WriteLine("Given number is {0} and is between {1} - {2}", numberN, minNumber, maxNumber);
            return numberN;
        }
    }            
}
