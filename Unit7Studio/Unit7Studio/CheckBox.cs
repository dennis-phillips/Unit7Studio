using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Unit7Studio
{
    public class CheckBox : Question
    {
        
        public string Name { get; set; } = "Select all that apply.";
        public int[] Answer { get; set; }
        public int[] UserAnswer { get; set; }

        public List<string> AnswerChoices { get; set; } = new List<string>();

        public CheckBox(string QuestionText, int[] answer, List<string> answerChoices) : base(QuestionText)
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

            Console.WriteLine("Please enter the correct items seperated by a comma (ie: 1,3): ");

        }

        public override void GetAnswer()
        {
            string userInput = Console.ReadLine();
            string[] userInputToStringArray = userInput.Split(",");
            //Console.WriteLine(userInputToStringArray[0],userInputToStringArray[1],userInputToStringArray[2]);
            UserAnswer = Array.ConvertAll(userInputToStringArray, Int32.Parse);
            //Console.WriteLine(UserAnswer[0].ToString() + UserAnswer[1].ToString() + UserAnswer[2].ToString());
            if (UserAnswer.SequenceEqual(Answer))
            {
                this.Score += 1;
                Console.WriteLine($"Great Job! Your answer is correct!");
            }
            else
            {
                Console.WriteLine($"Sorry. Your answer is incorrect.");
            }
        
        }
    }   
}
