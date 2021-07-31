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
            var workerHead = new ConstructionWorkerHead();

            workerHead.Color = LegoColor.Yellow;

            var batmanHead = new BatmanHead();

            var astronautHead = new AstronautHead();

            var heads = new List<HeadBase>() { astronautHead, batmanHead, workerHead };
            
            foreach (var head in heads)
            {
                head.SayHi();
                head.Spin();
            }
        }
    }
}
