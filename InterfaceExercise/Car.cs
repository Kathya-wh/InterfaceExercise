using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Car : IVehicle, ICompany

    {
        public int NumberOfDoors { get; set; } = 4;
        public string Color { get; set; } = "Blue";
        public bool Drives { get; set; } = true;
        public int Year { get; set; } = 1997;

        public string Name { get; set; } = "Toyota";
        public string Logo { get; set; } = "generic";
        public int NumberOfSeats { get; set; } = 4;
        public double TrunkSize { get; set; } = 5.4;
        public bool HasChangedGears { get; set; }
        public void Drive()
        {
            Console.WriteLine($"{GetType().Name} moving along...");
        }
        public void Reverse()
        {
            if(HasChangedGears == true)
            {
                Console.WriteLine($"{GetType().Name} we are in reverse...");
                HasChangedGears = false;
            }
            else
            {
                Console.WriteLine($"{GetType().Name} must change gears to reverse..");
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
                Console.WriteLine($"{GetType().Name} must change gears to park..");
            }
        }

        public void ChangeGears(bool IsChanged)
        {
            HasChangedGears = IsChanged;
        }
    }
}
