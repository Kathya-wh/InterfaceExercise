using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace InterfaceExercise
{
    public interface IVehicle
    {
        public int NumberOfDoors { get; set; }
        public string Color { get; set; }
        public bool Drives { get; set; }
        public int Year { get; set; }
        public bool HasChangedGears { get; set; }

        public void Drive();
        public void Reverse();
        public void Park();
        public void ChangeGears(bool IsChanged);

    }
}
