using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegoMinifiguresRevisited.Heads
{
    class HeadBase
    {
        public LegoColor Color { get; set; } // This will be set to the default enum color of Yellow unless we specify //



        // This method is used for all the Head Classes that are inheriting this HeadClass // 
        // Keyword 'Virtual' means that the classes that inherate this class, can change it. // 
        public virtual void SayHi()
        {
            Console.WriteLine("Hi");
        }
    }
}
