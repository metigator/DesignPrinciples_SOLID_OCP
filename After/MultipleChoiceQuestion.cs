using System;
using System.Collections.Generic;

namespace SOLID.OCP.After
{
    class MultipleChoiceQuestion : Question
    {
        public List<string> Choices { get; set; } = new List<string>();
        public override void Print()
        {
            Console.WriteLine($"{Title} [{Mark}]");

            foreach (var choice in Choices)
            {
                Console.WriteLine($"  {choice}");
            }
        }
    }

}
