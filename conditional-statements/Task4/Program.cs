using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt user
            // Read user first input
            Console.Write("Please enter first number");
                       
            string userInputFirst;
            int evaluatedNumberFirst;
            userInputFirst = Console.ReadLine();
            int.TryParse(userInputFirst, out evaluatedNumberFirst);

            // Read user second input
            Console.Write("Please enter second number");
                        
            string userInputSecond;
            int evaluatedNumberSecond;
            userInputSecond = Console.ReadLine();
            int.TryParse(userInputSecond, out evaluatedNumberSecond);

            // Read user third input
            string userInputThird;
            int evaluatedNumberThird;
            Console.Write("Please enter third number");
            userInputThird = Console.ReadLine();
            int.TryParse(userInputThird, out evaluatedNumberThird);
            
            // Evaluate user input number order  
            
            if (evaluatedNumberFirst < evaluatedNumberSecond)

            {
                if (evaluatedNumberSecond < evaluatedNumberThird)
                {
                    Console.WriteLine("{0},{1},{2}", evaluatedNumberFirst, evaluatedNumberSecond, evaluatedNumberThird);
                }
                    
                else if (evaluatedNumberFirst < evaluatedNumberThird)
                {
                    Console.WriteLine("{0},{1},{2}", evaluatedNumberFirst, evaluatedNumberThird, evaluatedNumberSecond);
                }
                    
                else
                {
                    Console.WriteLine("{0},{1},{2}", evaluatedNumberThird, evaluatedNumberFirst, evaluatedNumberSecond);
                }
                    
            }
            
            else
            {
                if (evaluatedNumberFirst < evaluatedNumberThird)
                {
                    Console.WriteLine("{0},{1},{2}", evaluatedNumberSecond, evaluatedNumberFirst, evaluatedNumberThird);
                }

                else if (evaluatedNumberSecond < evaluatedNumberThird)
                {
                              
                    Console.WriteLine("{0},{1},{2}", evaluatedNumberSecond, evaluatedNumberThird, evaluatedNumberFirst);
                }
                
                else
                {
                    Console.WriteLine("{0},{1},{2}", evaluatedNumberThird, evaluatedNumberSecond, evaluatedNumberFirst);
                }
                
            }

            // Wait for user input
            Console.ReadKey();
        }
    }
}
