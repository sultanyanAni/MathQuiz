using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Quiz
{

    public class Question
    {


        public Equation Equation;
        float CorrectAnswer => Equation.Answer();
        public int CorrectIndex;
        public float[] Answers;
        Random gen;


        public Question(Random gen, int numberOfAnswers = 4)
        {
            this.gen = gen;
            Equation = new Equation(gen);
            Answers = new float[numberOfAnswers];
        }

        /// <summary>
        /// fills the Answers array with random numbers and places the correct answer at a random index
        /// </summary>
        public void SetAnswers()
        {
            CorrectIndex = gen.Next(Answers.Length);
            Answers[CorrectIndex] = CorrectAnswer;

            //generating a random float, close to the correct answer (hopefully) //commenting out for now because its causing problems/leads to a more complex program
            //int ranNum = gen.Next(((int)CorrectAnswer - 10) * 1000, ((int)CorrectAnswer + 10) * 1000);
            //float ranFloat = ranNum / 1000.0f;

            int ranNum = 0;

            bool isValid = true;
            for (int i = 0; i < Answers.Length; i++)
            {
                if (i != CorrectIndex)
                {
                    do
                    {
                        isValid = true;
                        ranNum = gen.Next((int)CorrectAnswer - 10, (int)CorrectAnswer + 10);
                       
                        for (int j = 0; j < Answers.Length; j++)
                        {
                            if (Answers[j] == ranNum)
                            {
                                isValid = false;
                            }
                        }

                    } while (isValid == false);
                    Answers[i] = ranNum;
                }
            }

        }

    }
}

