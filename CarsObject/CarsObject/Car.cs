using System;
using System.Collections.Generic;
using System.Text;

namespace CarsObject
{
    class Car
    {
        // Private variables/fields
        private string _originalColor;
        // Properties
        public string Color { get; set; }
        public string Brand { get; }
        public string Model { get; set; }
        public double Speed { get; set; }
        // Constructor
        public Car(string color, string brand, string model)
        {
            Color = color;
            Brand = brand;
            Model = model;
            Speed = 0;
            _originalColor = color;
        }
        // Function
        public void Accelerate()
        {
            Speed = Speed + 10;
        }
        public void Accelerate(double value)
        {
            Speed = Speed + value;
        }
        // Slowdown
        public void Slowdown(double value)
        {
            Speed = Speed - value;
        }
        public override string ToString()
        {
            return $"Brand: {Brand}, Color: {Color}, Model: {Model}, Speed: {Speed}";
        }
    }
}
