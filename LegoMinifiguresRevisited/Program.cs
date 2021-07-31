using LegoMinifiguresRevisited.Heads;
using System;

namespace LegoMinifiguresRevisited
{
    class Program
    {
        static void Main(string[] args)
        {
            var head = new ConstructionWorkerHead();

            head.Color = LegoColor.Yellow;
            head.SayHi();

            var batmanHead = new BatmanHead();
            batmanHead.SayHi();

            var astronautHead = new AstronautHead();
            astronautHead.SayHi();
        }
    }
}
