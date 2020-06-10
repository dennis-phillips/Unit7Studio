using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Unit7Studio
{
    public class TrueOrFalse : Question 
    {




        public string Name { get; set; } = "True or False";
        public bool Answer { get; set; }
        public bool UserAnswer { get; set; }
        

        public TrueOrFalse(string QuestionText, bool answer) : base(QuestionText)
        {
            Answer = answer;
        }
        public TrueOrFalse()
        {
        }


        public override void DisplayQuestion()
        {
            Console.WriteLine(Name +":\n" + QuestionText);
            
            

        }

        public override void DisplayAnswers()
        {
            Console.Write("Please enter True or False: ");
           
           
        }
        public override void GetAnswer()
        {
            string userInput = Console.ReadLine();
            UserAnswer = bool.Parse(userInput.ToLower());
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
