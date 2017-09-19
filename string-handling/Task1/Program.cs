using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            Console.Write("Enter a string: ");
            userInput = Console.ReadLine();
            Console.WriteLine("You entered {0} characters",userInput.Length);
            Console.ReadKey();
        }
    }
}
