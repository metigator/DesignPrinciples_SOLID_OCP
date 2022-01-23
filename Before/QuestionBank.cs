using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.OCP.Before
{
    internal static class QuestionBank
    {
        public static List<Question> Generate()
        {
            return new List<Question>
            {
                new Question
                {
                    Title = "What are the four pillars of OOP?",
                    QuestionType = QuestionType.WH,
                    Mark = 8
                },
                new Question
                {
                    Title = "Which of the following are value types?",
                    QuestionType = QuestionType.MULTIPLECHOICE,
                    Mark = 6,
                    Choices = new List<string>
                    {
                        "A: Integer",
                        "B: Array",
                        "C: Single",
                        "D: String",
                        "E: Long",
                    }
                },
               new Question
                {
                    Title = "Earth is Bigger than sun?",
                    QuestionType = QuestionType.TRUEFALSE,
                    Mark = 4
                },
                new Question
                {
                    Title = "Which of the following is an 8-byte Integer?",
                    QuestionType = QuestionType.MULTIPLECHOICE,
                    Mark = 6,
                    Choices = new List<string>
                    {
                       "A.  Char",
                       "B.  Long",
                       "C.  Short",
                       "D.  Byte",
                       "E.  Integer"
                    }
                }

            };
        }
    }
}
