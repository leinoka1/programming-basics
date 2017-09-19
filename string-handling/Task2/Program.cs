using System;
using System.Linq;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            Console.Write("Enter a string: ");
            userInput = Console.ReadLine();
            Console.WriteLine("You entered {0}", userInput.Replace("e","@"));
            Console.ReadKey();
        }
    }
}
