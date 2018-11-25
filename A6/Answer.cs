using System;

namespace A6
{
    class Answer{

        public Answer (string pAnswer, bool isCorrect) {
            this.pAnswer = pAnswer;
            this.isCorrect = isCorrect;
        }

        public Answer () { }

        private string pAnswer;
        private bool isCorrect;

        public string GetAnswer()
        {
            return this.pAnswer;
        }

        public bool GetIsCorrect()
        {
            return this.isCorrect;
        }

        public void SetAnswer(string possibleAnswer)
        {
            this.pAnswer = possibleAnswer;
        }

        public void SetIsCorrect(bool isCorrect)
        {
            this.isCorrect = isCorrect;
        }
    }
}