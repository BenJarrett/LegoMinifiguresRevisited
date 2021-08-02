using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegoMinifiguresRevisited.Torsos
{
    class BatSuitTorso : TorsoBase
    {
        public bool HasBatBoomerang { get; set; }


        public override void Greeting()
        {
            base.Greeting();
            Console.WriteLine("Gives fist bump.");
        }

        public override void Wiggle()
        {
            Console.WriteLine("Flex on em!");
        }

        public void Donates()
        {
            Console.WriteLine("Donates 150 million to Children Are The Future Charity.");
        }
    }
}
