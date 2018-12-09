using System;
using System.Collections.Generic;
using System.Linq;

namespace A8
{
    class Program
    {
        static List<Quizelement> allQuestions = new List<Quizelement>();

        static void Main(string[] args)
        {
            defaultQuestions();
            while(true){
                Console.WriteLine("Möchtest du das Quiz spielen oder neue Fragen anlegen? Tippe spielen, neu oder exit um alles zu beenden");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "spielen":
                        Game();
                        break;
                    case "neu":
                        create();
                        break;
                    case "exit":
                        return;
                }
            }

        }

        public static void Game()
        {
            int frage = 1;
            int counter = 0;
            foreach (Quizelement question in allQuestions)
            {
                Console.WriteLine("Frage " + frage + ":");
                question.show();
                string response = Console.ReadLine();
                if (question.isAnswerCorrect(response))
                {
                    counter++;
                    Console.WriteLine("Richtig!");
                }
                else
                {
                    Console.WriteLine("Falsch!");
                }
                frage++;
                Console.WriteLine();
            }
            Console.WriteLine(counter + " von " + (frage - 1) + " Fragen richtig beantwortet.");
        }


        public static void create()
        {
            Console.WriteLine("Gib zuerst die Zahl des Fragentyps ein den du erstellen willst. (Normal: 1, Multiplechoice: 2, Wahr/Falsch: 3, Schätzen: 4, Freie Antwort: 5)");
            switch(Console.ReadLine()){
                case "1":
                    allQuestions.Add(new SingleQuestion(getQuestion(),getOptions()));
                    break;
                case "2":
                    allQuestions.Add(new MultiChoiceQuest(getQuestion(),getOptions()));
                    break;
                case "3":
                    allQuestions.Add(new BinaryQuestion(getQuestion(),trueOrFalse()));
                    break;
                case "4":
                    allQuestions.Add(new GuessQuestion(getQuestion(),Convert.ToInt32(getAnswer()),getRange()));
                    break;
                case "5":
                    allQuestions.Add(new FreeQuestion(getQuestion(),getAnswer()));
                    break;
                    

            }
        }

        public static string getQuestion(){
            Console.WriteLine("Gib bitte nun die Frage/Aussage ein");
            return Console.ReadLine();
        }

        public static string getAnswer(){
            Console.WriteLine("Gib nun den richtigen Wert/Antwort ein");
            return Console.ReadLine();
        }

        public static int getRange(){
            Console.WriteLine("Jetzt die maximale Abweichung zu dem zuvor eingegebenen Wert");
            return Convert.ToInt32(Console.ReadLine());
        }

        public static List<Answer> getOptions(){
            Console.WriteLine("Jetzt die möglichn Antworten(durch Kommas ohne Leerzeichen getrennt), die richtige(n) Antworten (nur bei MultipleChoice) bitte zuerst");
                string[] arrayNewAnswers = Console.ReadLine().Split(",");
                
                List<string> newAnswers = arrayNewAnswers.ToList();
                string correctAnswer = newAnswers[0];
                newAnswers.RemoveAt(0);
                int rand = new Random().Next(0,arrayNewAnswers.Length);
                int i = 0;
                List<Answer> temp = new List<Answer>();
                foreach(string answer in newAnswers){
                    if(i == rand){
                        temp.Add(new Answer(correctAnswer,true));
                    }
                    temp.Add(new Answer(answer,false));
                    i++;
                }
            return temp;
        }

        public static bool trueOrFalse(){
            Console.WriteLine("Ist die Frage/Aussage wahr oder falsch?");
            string input = Console.ReadLine();
            if(input.Equals("wahr"))
                return true;
            else if(input.Equals("falsch"))
                return false;
            else{
                Console.WriteLine("Eingabe invalid, bitte wiederholen");
                return trueOrFalse();
            }
        }

        public static void defaultQuestions()
        {
            allQuestions.Add(
                new MultiChoiceQuest(
                    "Wie findest du dieses Quiz",
                    new List<Answer>{
                        new Answer("Super",true),
                        new Answer("Kacke", false),
                        new Answer("Doof", false),
                        new Answer("End Geil", true),
                        new Answer("nervend", false),
                        new Answer("naja solala", false)
                    }
                )
            );

            allQuestions.Add(
                new SingleQuestion(
                    "Alle meine ... schwimmen auf dem See",
                    new List<Answer>{
                        new Answer("Atomböbchen",false),
                        new Answer("Eselchen",false),
                        new Answer("Entchen",true),
                        new Answer("Otten",false)
                    }
                )
            );

            allQuestions.Add(
                new FreeQuestion(
                    "Wer ist unser Bundeskanzler?",
                    "Angela Merkel"
                )
            );

            allQuestions.Add(
                new GuessQuestion(
                    "Welchen Umfang hat die Erde",
                    40000,
                    10000
                )
            );

            allQuestions.Add(
                new BinaryQuestion(
                    "Links ist da wo der Daumen rechts ist!",
                    true
                )
            );
        }
    }
}
