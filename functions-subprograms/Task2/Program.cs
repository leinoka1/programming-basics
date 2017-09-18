using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstNumber, secondNumber;
            int evaluatedNumberFirst, evaluatedNumberSecond;
            Console.Write("Input firts number: ");
            firstNumber = Console.ReadLine();
            int.TryParse(firstNumber, out evaluatedNumberFirst);
            Console.Write("Input second number: ");
            secondNumber = Console.ReadLine();
            int.TryParse(secondNumber, out evaluatedNumberSecond);
            int Minimi(int number1, int number2)
                {
                    if (number1 <= number2)
                    {
                        return number1;
                    }
                    else
                    {
                        return number2;
                    }
                }
                Console.WriteLine("Min is {0}", Minimi(evaluatedNumberFirst,evaluatedNumberSecond));
                Console.ReadKey();
        }
    }
}
