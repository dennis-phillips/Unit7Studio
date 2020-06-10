using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Unit7Studio
{
    public class Quiz
    {
       

        string QuestionNumber { get; set; }
        public double FinalScore { get; set; } = 0;

        public List<Question> QuizQuestions { get; set; } = new List<Question>();

        public Quiz()
        {
            QuizQuestions = QuizQuestions;
        }

        public void AddQuestions(Question question)
        {
            
            QuizQuestions.Add(question);
            //return QuizQuestions;
        }
        public void RunQuiz(List<Question> quizquestions)
        {
            foreach (Question item in quizquestions)
            {
                item.DisplayQuestion();
                item.DisplayAnswers();
                item.GetAnswer();
                FinalScore += item.Score;
               
                
            }
            double average = Math.Round((FinalScore / quizquestions.Count) * 100);

            Console.WriteLine($"Your current score is {average}%. {FinalScore} correct questions out of {quizquestions.Count.ToString()} questions.");
        }
        
    }
}
