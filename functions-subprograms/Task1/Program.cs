using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input: ");
            string numberOfStars;
            int evaluatedNumber;
            numberOfStars = Console.ReadLine();
            int.TryParse(numberOfStars, out evaluatedNumber);
            string CreateStarString()
            {
                if (evaluatedNumber <= 0)
                {
                    return null;
                }
                else
                {
                    string starSt = null;
                    int i;
                    for (i = 1; i <= evaluatedNumber; i++)
                    {
                        string star = "*";
                        starSt = starSt + star;
                    }
                    return starSt;
                }
            }
            if (CreateStarString () == null)
            {
                Console.WriteLine("Input {0} not valid", evaluatedNumber);
            }
            else
            {
                Console.WriteLine("Output: {0}", CreateStarString());
            }
            Console.ReadKey();
        }
    }
}
