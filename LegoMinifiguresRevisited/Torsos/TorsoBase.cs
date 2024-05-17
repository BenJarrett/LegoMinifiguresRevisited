using LegoMinifiguresRevisited.Heads;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegoMinifiguresRevisited.Torsos
{
    abstract class TorsoBase
    {
        public bool HasShirt { get; set; }
        public LegoColor BodyColor { get; set; }
        public string ToolBelt { get; set; }

        // Generic method that can be overriden // 
        public virtual void Greeting()
        {
            Console.WriteLine("Give a high five!");
        }

        // Allows each torso to difine their own Wiggle method //
        public abstract void Wiggle();

    }
}
