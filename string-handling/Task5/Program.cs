using System;
using System.Linq;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Number of vowels in any given string
            // Effient way of doing this ...
            string userInput;
            int j = 0;
            int k = 0;
            string vowels = "aeiou".ToUpper();
            Console.Write("Enter a string: ");
            userInput = Console.ReadLine().ToUpper();
            foreach(Char c in userInput)
            {
                if (vowels.Contains(c))       
                    k++;
            }
            // Another way of doing this...
            for (int i = 0; i < userInput.Length; i++)
            {
                char c = userInput[userInput.Length - i - 1];
                if (c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U')
                   j++;
            }
            Console.WriteLine("Number of vowels in given string is {0} {1} ", k,j);
            Console.ReadLine();
        }
    }
}
