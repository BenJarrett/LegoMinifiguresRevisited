using LegoMinifiguresRevisited.Heads;
using System;
using System.Collections.Generic;

namespace LegoMinifiguresRevisited
{
    class Program
    {
        // Polymorphism // 

        // Anything that has that "is a" relationship (inheritance), can be treated if it's
        // the same kind of thing //
        // Allows us to call the same code on the methods of multple classes //
        static void Main(string[] args)
        {
            // Defining the variable 'workerHead' and setting it equal to a new ConstructionWorkerHead //
            var workerHead = new ConstructionWorkerHead();

            // Setting the workerHead to the yellow value of the LegoColor enum //
            workerHead.Color = LegoColor.Yellow;

            // Defining the variable 'batmanHead' and setting it equal to a new BatmanHead //
            var batmanHead = new BatmanHead();

            // Defining the variable 'astronautHead' and setting it equal to a new AstronautHead //
            var astronautHead = new AstronautHead();

            // 
            var heads = new List<HeadBase>() { astronautHead, batmanHead, workerHead };
            
            // For loop that loops through each head in the heads class.
            // It runs the SayHi and Spin on each head that it loops thorugh // 
            foreach (var head in heads)
            {
                head.SayHi();
                head.Spin();
            }
            // RESULT //
            // Hi
            // Major Tom to Ground Control...
            // The Astronaut head spins to take in the beauty of the cosmos...
            // I'm Batman!
            // Where is the joker?
            // Hi
            // The Yellow Construction Worker Head spins after being hit by a girder. //
            // END OF RESULT //


        }
    }
}
