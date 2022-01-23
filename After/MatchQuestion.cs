using System;
using System.Collections.Generic;

namespace SOLID.OCP.After
{
    class MatchQuestion : Question
    {
        public Dictionary<string, string> Rows { get; set; }
            = new Dictionary<string, string>();
        public override void Print()
        {
            Console.WriteLine($"{Title} [{Mark}]"); 

            foreach ( var item in Rows)
            {
                Console.WriteLine($"{item.Key}            {item.Value}");
            }
        }
    }
}
