using System;
using System.Collections.Generic;
using System.Text;

namespace Unit7Studio
{
    public abstract class Question 
    {
        
        public string QuestionText { get; set; }

        public double Score { get; set; } = 0;

        protected Question(string questionText)
        {
            QuestionText = questionText;
        }

        protected Question()
        {
        }

        protected Question(string questionText, int score) : this(questionText)
        {
            Score = score;
        }

        public virtual void DisplayQuestion() { }




        public virtual void DisplayAnswers() { }
        
        public virtual void GetAnswer() { }
        
    }
}
