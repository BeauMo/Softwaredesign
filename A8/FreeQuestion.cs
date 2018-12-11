using System;
using System.Collections.Generic;

namespace A8
{

    class FreeQuestion : Quizelement
    {

        public FreeQuestion(string question, string textAnswer)
        {
            this.question = question;
            this.textAnswer = textAnswer;
            this.callToAction = "Geben sie eine Antwort ein";
        }

        public string textAnswer;

        public override void show()
        {
            Console.WriteLine(this.callToAction);
            Console.WriteLine(this.question);
        }

        public override bool isAnswerCorrect(string userAnswer)
        {
            if (userAnswer.Equals(this.textAnswer))
                return true;
            else
                return false;
        }

    }
}