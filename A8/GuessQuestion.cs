using System;
using System.Collections.Generic;

namespace A8{

    class GuessQuestion : Quizelement{

        public GuessQuestion(string question, int correctValue, int range){
            this.question = question;
            this.correctValue = correctValue;
            this.range = range;
            this.callToAction = "Schätze den Wert und geb ihn ein";
        }

        public int correctValue;

        public int range;

        public override void show(){
            Console.WriteLine(callToAction);
            Console.WriteLine(question);
        }

        public override bool isAnswerCorrect(string userAnswer){
            int intAnswer = Convert.ToInt32(userAnswer);
            if(intAnswer > correctValue - range && intAnswer < correctValue + range)
                return true;

            return false;
        }

    }
}