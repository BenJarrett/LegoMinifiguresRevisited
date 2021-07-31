using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegoMinifiguresRevisited.Heads
{   
    // Abstract Class //
    // When creating a class that you do not intend to abstantiate, it can be marked as Abstract //
    // The idea of a thing, but not actually a thing // 
    // Only used to be inherited from //
    abstract class HeadBase
    {
        public LegoColor Color { get; set; } // This will be set to the default enum color of Yellow unless we specify //


        // Virtual Method // 
        // This method is used for all the Head Classes that are inheriting this HeadClass // 
        // Keyword 'Virtual' means that the classes that inherate this class, can change it. // 
        public virtual void SayHi()
        {
            Console.WriteLine("Hi");
        }

        // Abstact Method // 

        // Abstract class defines the idea of a method // 
        // Every class that inherits from HeadBase, must have a method that looks like thi s // 
        // Abstract method that doesn't return anything // 
        // Now that I defined this method in the Abstract Class, every class inheriting from this class should have 
        // A version of this method // 
        public abstract void Spin();
    }
}
