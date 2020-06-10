using System;
using System.Collections.Generic;
using System.Text;

namespace Unit7Studio
{
    public class MultipleChoice : Question
    {
        

        public string Name { get; set; } = "Multiple Choice";
        public int Answer { get; set; }
        public int UserAnswer { get; set; }

        public List<string> AnswerChoices { get; set; } = new List<string>();

        public MultipleChoice(string QuestionText, int answer, List<string> answerChoices) : base(QuestionText)
        {
            Answer = answer;
            AnswerChoices = answerChoices;
        }


        public override void DisplayQuestion()
        {
            Console.WriteLine(Name + ":\n" + QuestionText);

        }

        public override void DisplayAnswers()
        {
            foreach (string answer in AnswerChoices)
            {

                Console.WriteLine(answer);
            }
                Console.WriteLine("Please enter the number corresponding to the correct answer: ");
        }
        public override void GetAnswer()
        {
            string userInput = Console.ReadLine();
            UserAnswer = Int32.Parse(userInput);
            if (UserAnswer == Answer)
            {
                this.Score += 1;
                Console.WriteLine($"Great Job! {UserAnswer} is correct!");
            }
            else
            {
                Console.WriteLine($"Sorry. {UserAnswer} is incorrect, the correct answer is {Answer}");
            }


        }
    }
}
