using System;
using System.Collections.Generic;

namespace A8
{

    class MultiChoiceQuest : Quizelement
    {

        public MultiChoiceQuest(string question, List<Answer> answers)
        {
            this.question = question;
            this.answers = answers;
            this.callToAction = "Gebe alle Buchstaben der richtigen Antwort mit Komma getrennt ein (ohne Leerzeichen).";
        }

    }
}