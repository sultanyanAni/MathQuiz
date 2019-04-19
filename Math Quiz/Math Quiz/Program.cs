using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Question> questions = new List<Question>();
            List<char> AnswerKey = new List<char>();
            List<char> UserAnswers = new List<char>();
            int correct = 0;
            Random gen = new Random();

            //generating Questions and creating an answer key using the correct index variable 
            for (int i = 0; i < 5; i++)
            {
                questions.Add(new Question(gen, gen.Next(4,6)));
                questions[i].SetAnswers();
                AnswerKey.Add((char)(questions[i].CorrectIndex + 65));
            }
            
            //displaying questions and possible answers. also taking in user answers and adding them to a list.
            for (int i = 0; i < questions.Count; i++)
            {
                Console.WriteLine($"{i + 1}) {questions[i].Equation.GetEquation()}");
                for (int j = 0; j < questions[i].Answers.Length; j++)
                {
                    
                    Console.WriteLine($"{(char)(65+j)}.{questions[i].Answers[j]}");
                    
                   
                }
                UserAnswers.Add(Console.ReadLine().ToUpper()[0]);
            }

            //comparing user answers with the answer key, counting correct answers
            for (int i = 0; i < AnswerKey.Count; i++)
            {
                if(UserAnswers[i] == AnswerKey[i])
                {
                    correct++;
                }
            }

            Console.WriteLine($"You got {correct} out of {questions.Count} right!");

            Console.ReadKey();
        }
    }
}
