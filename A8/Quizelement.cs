using System;
using System.Collections.Generic;

namespace A8
{
    class Quizelement
    {

        public string question;

        public List<Answer> answers;

        public string callToAction;

        public virtual void show()
        {
            Console.WriteLine(callToAction);
            Console.WriteLine(question);
            Console.WriteLine();
            int prefix = 97;  // 97 = ascii for a 
            foreach (Answer option in answers)
            {
                Console.WriteLine((char)prefix + ") " + option.Get());
                prefix++;
            }
        }

        public virtual bool isAnswerCorrect(string userAnswer)
        {
            string[] userAnswers = userAnswer.Split(",");
            foreach (string subAnswer in userAnswers)
            {
                int chr = subAnswer[0] - 97;
                if (answers[chr].GetIsCorrect() == false)
                    return false;
            }

            if (howManyRight(answers) != userAnswers.Length)
                return false;
            else
                return true;

        }

        private static int howManyRight(List<Answer> answers)
        {
            int i = 0;
            foreach (Answer answer in answers)
            {
                if (answer.GetIsCorrect())
                    i++;
            }
            return i;
        }
    }
}