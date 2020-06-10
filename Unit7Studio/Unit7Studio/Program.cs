using System;
using System.Collections.Generic;

namespace Unit7Studio
{
    class Program
    {
        static void Main(string[] args)
        {
            TrueOrFalse Question1 = new TrueOrFalse();
            Question1.QuestionText = "Javascript is easier than 'C#'.";
            Question1.Answer = true;
            TrueOrFalse Question2 = new TrueOrFalse();
            Question2.QuestionText = "Moe is the Man.";
            Question2.Answer = true;
            TrueOrFalse Question3 = new TrueOrFalse("Dennis can code!", true);
            //Console.WriteLine(Question1.QuestionText);
            Quiz NewQuiz = new Quiz();
            NewQuiz.AddQuestions(Question1);
            //Console.WriteLine(NewQuiz.QuizQuestions[0].QuestionText);
            NewQuiz.AddQuestions(Question2);
            NewQuiz.AddQuestions(Question3);
            //Console.WriteLine(NewQuiz.QuizQuestions[1].QuestionText);
            List<string> AnswersList = new List<string>();
            AnswersList.Add("1. Blue");
            AnswersList.Add("2. Red");
            AnswersList.Add("3. Black");
            MultipleChoice Question4 = new MultipleChoice("What color is the sky?", 1, AnswersList);
            NewQuiz.AddQuestions(Question4);
            List<string> AnswersList2 = new List<string>();
            AnswersList2.Add("1. C");
            AnswersList2.Add("2. C#");
            AnswersList2.Add("3. Javascript");
            AnswersList2.Add("4. Google");
            int[] correct = { 1, 2, 3 };
            CheckBox Question5 = new CheckBox("Which of the following are programming languages?",correct,AnswersList2);
            NewQuiz.AddQuestions(Question5);
            NewQuiz.RunQuiz(NewQuiz.QuizQuestions);
            
        }
    }
}
