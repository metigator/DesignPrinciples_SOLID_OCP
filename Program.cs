using System;
using System.Collections.Generic;

namespace SOLID.OCP
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            var quiz = new After.Quiz(After.QuestionBank.Generate());

            quiz.Print();

            Console.ReadKey();
        }
    }
}