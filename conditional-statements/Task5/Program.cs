using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt user
            // Read user first input
            // First Welcome message

            Console.Write("Welcome to Agri exhibition!");

            // A visitor is asked to give age of the visitor
            Console.Write("Please enter your age!");
            string userInputAge;
            int evaluatedNumberAge;
            userInputAge = Console.ReadLine();
            int.TryParse(userInputAge, out evaluatedNumberAge);
            
            // Confirm Age
            Console.WriteLine("Your age is {0}", evaluatedNumberAge);

            // Visor is asked memnbershiof of MTK
            Console.Write("Are you a member of MTK (Y/N)?");
            string userInputMembership;
            int evaluatedNumberMembership;
            userInputMembership = Console.ReadLine();
            int.TryParse(userInputMembership, out evaluatedNumberMembership);

            // Visitor asked if he is a stundent
            Console.Write("Are you a student (Y/N)?");
            string userInputStudent;
            int evaluatedNumberStudent;
            userInputStudent = Console.ReadLine();
            int.TryParse(userInputStudent, out evaluatedNumberStudent);

            // Visitor asked if he is doing his military service
            Console.Write("Are you doing your military service (Y/N)?");
            string userInputMilitary;
            int evaluatedNumberMilitary;
            userInputMilitary = Console.ReadLine();
            int.TryParse(userInputMilitary, out evaluatedNumberMilitary);

            // Calculate ticket price
            // Ehdot: Vain yksi alennus myönnetään. Paitsi, jos on opiskelija sekä Mtk:n jäsen, hän saa molemmat alennukset.
            // Normaalihinta 16 e
            // Alle 7 v.ilmaiseksi
            // 65 v.ja yli: 50 % alennus
            // 7 - 15 v. 50 % alennus
            // Mtk jäsen: 15 % alennus
            // Varusmies: 50 % alennus
            // Opiskelija: 45 % alennus

            // First Membership
            if (userInputMilitary == "Y")
            {
                Console.WriteLine("Ticket price is 8 e");
            }

            else if (userInputStudent == "Y")

            {
                Console.WriteLine("Ticket price is 8,80 e");
            }

            else if (userInputMembership == "Y")

            {
                Console.WriteLine("Ticket price is 13,60 e");
            }
            else
            {
                Console.WriteLine("Ticket price is 16 e");
            }


            // Age discounts
            if (evaluatedNumberAge < 7)
            {
                Console.WriteLine("Free of charge");
            }

            else if (65 < evaluatedNumberAge)
            {
                Console.WriteLine("Free of charge");
                
            }
            else if (7 < evaluatedNumberAge)
                if (15 > evaluatedNumberAge)
                    Console.WriteLine("Ticket price is 8 e");
                else 
                        Console.WriteLine("Ticket price is 16 e");
            else
                {
            }
                




                    // Wait for user input
                    Console.ReadKey();
        }
        
    }
}
