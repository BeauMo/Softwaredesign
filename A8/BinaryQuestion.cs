using System;
using System.Collections.Generic;

namespace A8{

    class BinaryQuestion : Quizelement{

        public BinaryQuestion(string question, bool right){
            this.question = question;
            this.right = right;
            this.callToAction = "Wahr oder Fasch?";
        }

        public bool right;

        public override void show(){
            Console.WriteLine(callToAction);
            Console.WriteLine(question);
        }

        public override bool isAnswerCorrect(string userAnswer){
            if(userAnswer.Equals("Wahr") && right == true)
                return true;
            if(userAnswer.Equals("Falsch") && right == false)
                return true;

            return false;
        }

    }
}