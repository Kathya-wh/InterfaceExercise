using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class SUV : IVehicle, ICompany
    {
        public int NumberOfDoors { get; set; } = 5;
        public string Color { get; set; } = "Silver";
        public bool Drives { get; set; } = true;
        public int Year { get; set; } = 2020;

        public string Name { get; set; } = "Lexus";
        public string Logo { get; set; } = "genetic";
        public bool HasChangedGears { get; set; }
        public int NumberOfSeats { get; set; } = 7;
        public double CargoSize { get; set; } = 12.8;

        public void Drive()
        {
            Console.WriteLine($"{GetType().Name} moving along...");
        }
        public void Reverse()
        {
            if (HasChangedGears == true)
            {
                Console.WriteLine($"{GetType().Name} we are in reverse...");
                HasChangedGears = false;
            }
            else
            {
                Console.WriteLine($"{GetType().Name} must change gears to reverse...");
            }
        }
        public void Park()
        {
            if (HasChangedGears == true)
            {
                Console.WriteLine($"{GetType().Name} we are parking...");
                HasChangedGears = false;
            }
            else
            {
                Console.WriteLine($"{GetType().Name} must change gears to park...");
            }
        }
        public void ChangeGears(bool IsChanged)
        {
            HasChangedGears = IsChanged;
        }
    }
}
