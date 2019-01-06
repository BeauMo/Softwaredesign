using System;

namespace A8{

    class Answer{
        
        public Answer(string option, bool correct){
            this.option = option;
            this.correct = correct;
        }

        public string option;

        public bool correct;

        public string Get(){
            return this.option;
        }

        public bool GetIsCorrect()
        {
            return this.correct;
        }

    }
}