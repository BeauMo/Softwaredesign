using System;
using System.Collections.Generic;

namespace A8
{

    class SingleQuestion : Quizelement
    {

        public SingleQuestion(string question, List<Answer> answers)
        {
            this.question = question;
            this.answers = answers;
            this.callToAction = "Gebe den Buchstaen der richtigen Antwort ein.";
        }

    }
}