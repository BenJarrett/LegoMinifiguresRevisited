using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegoMinifiguresRevisited.Heads
{
    class AstronautHead
    {
        // Set Color to the default value of the LegoColor enum // 
        // Set FacialHair to the default value of the FacialHair enum // 
        public LegoColor Color { get; set; }
        public bool WearingHelmet { get; set; }
        public FacialHair FacialHair { get; set; }
        
        public void SayHi()
        {
            Console.WriteLine("Major Tom to Ground Control...");
        }

        public void Spin()
        {
            Console.WriteLine("The Astronaut head spins to take in the beauty of the cosmos...");
        }

        public void Shave()

            // When we initiate this method, the FacialHair property of the Astronaut will be set to the FacialHair.None value of the FacialHair Enum //
        {
            Console.WriteLine($"The Astronaut head shaves its {FacialHair}.");
            FacialHair = FacialHair.None;
        }

    }
}
