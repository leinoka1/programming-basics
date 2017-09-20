using System;
using System.Linq;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                string userInput;
                int i = 0;
                Console.Write("Enter a string: ");
                userInput = Console.ReadLine().ToUpper();
                /*int count = userInput.Where(c => c == 'L').ToList().Count;
                Console.WriteLine(count);
                Console.ReadLine();
                */
                foreach (char c in userInput)
                {
                    if (c == 'L')
                    {
                        i++;
                    }
                }
                Console.WriteLine("Your string contains letter L or l {0} times. ",i);
                Console.ReadLine();
            }
        }
    }
}
