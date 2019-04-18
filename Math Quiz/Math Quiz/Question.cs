using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Quiz
{

    public class Question
    {


        Equation equation;
        int CorrectAnswer => equation.Answer();
        int CorrectIndex { get; set; }
        int[] Answers;
        Random gen;
        public Question(int numberOfAnswers)
        {
            gen = new Random();
            equation = new Equation();
            Answers = new int[numberOfAnswers];
        }
        /// <summary>
        /// fills the Answers array with random numbers and places the correct answer at a random index
        /// </summary>
        public void SetAnswers()
        {
            CorrectIndex = gen.Next(Answers.Length + 1);
            Answers[CorrectIndex] = CorrectAnswer;

            for (int i = 0; i < Answers.Length; i++)
            {
                if(i != CorrectIndex)
                {
                    Answers[i] = gen.Next(CorrectAnswer - 10, CorrectAnswer + 10);
                }
            }

        }
        
    }
}
