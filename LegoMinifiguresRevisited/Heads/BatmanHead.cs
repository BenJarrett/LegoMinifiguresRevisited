using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegoMinifiguresRevisited.Heads
{
    class BatmanHead : HeadBase 
        // defining class Properties //
        // FacialExpression has a default of 'Stoic' //
        // Set Property Color to the enum LegoColor.Black value //
    {
        public bool IsWearingMask { get; set; }
        public string Version { get; set; }
        public string FacialExpression { get; set; } = "Stoic";
           
        // Since we are inheriting LegoColor from teh HeadBase Class
        // We have to create this constructor to set the default color fo the BatmanHead Class //
        public BatmanHead()
        {
            Color = LegoColor.Black;
        }

        public void Spin()
        {
            Console.WriteLine("Where is the joker?");
        }


        // The Override means I am changing the way this behaviour works //
        // This is being inherited from the HeadBase Class // 
        // This is changing it from the default implimentation of this method from the HeadBase Class //
        public override void SayHi()  
        { 
            Console.WriteLine("I'm Batman!");
        }

        
    }
}
