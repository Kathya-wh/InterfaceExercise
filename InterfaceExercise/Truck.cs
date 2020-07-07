using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Truck : IVehicle, ICompany
    {
        public int NumberOfDoors { get; set; } = 2;
        public string Color { get; set; } = "white";
        public bool Drives { get; set; } = true;
        public int Year { get; set; } = 2005;
        public bool HasChangedGears { get; set; }
        public string Name { get; set; } = "Mazda";
        public string Logo { get; set; } = "Generic";
        public int NumberOfSeats { get; set; } = 3;
        public double BedSize { get; set; } = 10.3;

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
