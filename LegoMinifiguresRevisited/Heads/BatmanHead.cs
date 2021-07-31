using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegoMinifiguresRevisited.Heads
{
    class BatmanHead
        // defining class Properties //
        // FacialExpression has a default of 'Stoic' //
        // Set Property Color to the enum LegoColor.Black value //
    {
        public bool IsWearingMask { get; set; }
        public string Version { get; set; }
        public string FacialExpression { get; set; } = "Stoic";
        public LegoColor Color => LegoColor.Black; // Expression Bodied Property - Read Only //


        public void Spin()
        {
            Console.WriteLine("Where is the joker?");
        }

        public void SayHi()
        { 
            Console.WriteLine("I'm Batman!");
        }

        
    }
}
