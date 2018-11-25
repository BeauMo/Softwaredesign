using System;
using System.Collections.Generic; 

namespace A6
{
    class Quizelement {

        public Quizelement (string question, List<Answer> answers) {
            this.question = question;
            this.answers = answers;
        }
        private string question;
        private List<Answer> answers;
        
        public int GetCorrectAnswer() 
        {
            int i = 0;
            foreach(Answer answer in answers) 
            {
                if(answer.GetIsCorrect()) 
                {
                    return i;
                }
                i++;
            }
            return 5;
        }

        public string GetQuestion()
        {
            return this.question;
        }

        public void SetQuestion(string question)
        {
            this.question = question;
        }

        public List<Answer> GetAnswers()
        {
            return this.answers;
        }

        public void SetPossibleAnswers(List<Answer> answers)
        {
            this.answers = answers;
        }
    }
}