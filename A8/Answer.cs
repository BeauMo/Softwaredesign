using System;

namespace A8{

    class Answer{
        
        public Answer(string option, bool correct){
            this.option = option;
            this.correct = correct;
        }

        private string option;

        private bool correct;

        public string Get(){
            return this.option;
        }

        public bool GetIsCorrect()
        {
            return this.correct;
        }

    }
}