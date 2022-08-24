using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Builder
{
    public class Car : ICar
    {
        public string Engine { get; set; }
        public string Tires { get; set; }
        public string Suspensions { get; set; }
        public string Model { get; set; }
        public string Garage { get; set; }

        public void GetAllCarDetails()
        {
            Console.WriteLine("-----------------");
            Console.WriteLine($"Car comes from garage: {Garage}");
            Console.WriteLine($"Car Model: {Model}");
            Console.WriteLine($"Car Engine: {Engine}");
            Console.WriteLine($"Car Suspensions: {Suspensions}");
            Console.WriteLine($"Car Tires: {Tires}");
        }
    }
}