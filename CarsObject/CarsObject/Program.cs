using System;

namespace CarsObject
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string userInput = String.Empty;
            int speed;
            Console.WriteLine("Hello Cars");
            Car car = new Car("blue", "Volvo", "V50");
            Console.WriteLine(car);
            /*car.Accelerate();
            car.Accelerate(15);
            car.Slowdown(18);
            Console.WriteLine(car);
            car.Color = "red";
            Console.WriteLine(car);
            */
            Console.ReadLine();
            Console.Write("Paljonko tiputetaan huippunopeutta:", userInput);
            userInput = Console.ReadLine();
            int.TryParse(userInput, out speed);
            car.Slowdown(speed);
            Console.WriteLine(car);
            Console.ReadLine();
        }
    }
}
