using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Palindrom tester
            string userInput;
            string userInputPlainText=String.Empty;
            string reverseOrder = null;
            Console.Write("Enter a string: ");
            userInput = Console.ReadLine().ToUpper();
            for (int i = 0; i < userInput.Length; i++)
            {
                int j = userInput.Length - i;
                if (Char.IsLetter(userInput[userInput.Length - j ]))
                userInputPlainText = userInputPlainText + userInput[userInput.Length - j ];
            }
            Console.WriteLine("Your string as a plain text {0} ", userInputPlainText);
            for (int i = 0; i < userInputPlainText.Length; i++)
            {
                reverseOrder = reverseOrder + userInputPlainText[userInputPlainText.Length - i - 1];
            }
            Console.WriteLine("Your string backwards is {0} ", reverseOrder);
            if (reverseOrder == userInputPlainText)
            {
                Console.WriteLine("Given string is a palindrom!");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Given string is NOT a palindrom!");
                Console.ReadLine();
            }
        }
    }
}
