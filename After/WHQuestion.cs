using System;

namespace SOLID.OCP.After
{
    class WHQuestion : Question
    {
        public override void Print()
        {
            Console.WriteLine($"{Title} [{Mark}]");
            Console.WriteLine("  _____________________________");
            Console.WriteLine("  _____________________________");
            Console.WriteLine("  _____________________________");
        }
    }
}
