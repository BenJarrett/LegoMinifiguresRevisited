using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegoMinifiguresRevisited.Heads
{
    class ConstructionWorkerHead
    {
        // I set the 'Color' Propterty to the the Lego Color Enum //
        // This Property can now only be set to valid properties of the enum //
        public bool HasMullet { get; set; }
        public LegoColor Color { get; set; } // This will be set to the default enum color of Yellow unless we specify //
        public int NumberOfTeeth { get; set; }
        public bool WearingHardHat { get; set; }

        // This is still a behavior. It does not always have to be void and return nothing //
        // We are setting the property 'WearingHardHat' to the opposite value //
        // We then return the value of the result of the 'WearingHardHat' property //
        // Using a Ternary to write whether the worker is wearing or not wearing their hard hat // 
        public bool ToggleWorking()
        {
            WearingHardHat = !WearingHardHat;

            Console.WriteLine($"The Construction Worker Head {(WearingHardHat ? "is" : "is not")} wearing their hard hat.");

            return WearingHardHat;
        }

        // Every time this method is initiated, the worker will lose 1 tooth // 
        // The iff block will not run if the worker does not have more than 0 teeth
        public void Spin()
        {
            if (NumberOfTeeth > 0) ;
            NumberOfTeeth -= 1;

            Console.WriteLine($"The {Color} Construction Worker Head spins after being hit by a girder.");
        }

        public void SayHi()
        {
            Console.WriteLine("The Construction Worker Head says hello.");
        }
    }



}
