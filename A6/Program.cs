using System;
using System.Collections.Generic;
using System.Linq;

namespace A6
{
    class Program
    {
        static List<Quizelement> allQuestions = new List<Quizelement>();
        static void Main(string[] args)
        {
            defaultQuestions();
            Quiz();
        }

        public static void Quiz(){
            char[] abcdef = { 'a', 'b', 'c', 'd', 'e', 'f' };

            int counter = 0;

            Console.WriteLine("Möchtest du ein Spiel spielen Ja/Nein");
            string input = Console.ReadLine();

            if (input.Equals("Ja"))
            {
                int frage = 1;
                foreach (Quizelement question in allQuestions)
                {
                    int i = 0;
                    Console.WriteLine("Frage " + frage + ":");
                    Console.WriteLine(question.GetQuestion());
                    Console.WriteLine();
                    foreach (Answer answers in question.GetAnswers())
                    {
                        Console.WriteLine(abcdef[i] + ") " + answers.GetAnswer());
                        i++;
                    }
                    Console.WriteLine("Tippe den Buchstaben der richtigen Antwort ein.");
                    string response = Console.ReadLine();
                    if (abcdef[question.GetCorrectAnswer()].ToString().Equals(response))
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
                Console.WriteLine(counter + " von " + (frage-1) + " Fragen richtig beantwortet.");
            }
            else if (input.Equals("Nein"))
            {
                Console.WriteLine("Dann musst du mir helfen Fragen zu erstellen");
                Console.WriteLine("Gib zuerst eine neue Quizfrage ein.");
                string newQuest = Console.ReadLine();
                Console.WriteLine("Jetzt die möglichn Antworten(durch Kommas ohne Leerzeichen getrennt), die richtige Antwort bitte zuerst");
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
                allQuestions.Add(new Quizelement(newQuest,temp));
            }
            else
            {
                Console.WriteLine("Eingabe nicht erkannt");
            }
            Console.WriteLine("Wenn du wieder zurück zum anfang willst tippe weiter ein, zum beenden beliebige Taste eingeben");
            if(Console.ReadLine().Equals("weiter")){
                Quiz();
            }
        }

        public static void defaultQuestions()
        {

            List<Answer> answers1 = new List<Answer>{
                new Answer("Ich",true),
                new Answer("Du",false),
                new Answer("Er",false),
                new Answer("Sie",false)
            };
            Quizelement question1 = new Quizelement("Wer ist der Babo", answers1);
            allQuestions.Add(question1);

            List<Answer> answers2 = new List<Answer>{
                new Answer("Mond",true),
                new Answer("Sonne",false),
                new Answer("Erde",false),
                new Answer("Mars",false)
            };
            Quizelement question2 = new Quizelement("Wo ist Mond der Mondbär", answers2);
            allQuestions.Add(question2);

            List<Answer> answers3 = new List<Answer>{
                new Answer("Papier",true),
                new Answer("Lava",false),
                new Answer("Obihörnchen",false),
                new Answer("Brunnen",false)
            };
            Quizelement question3 = new Quizelement("Schere, Stein,", answers3);
            allQuestions.Add(question3);

            List<Answer> answers4 = new List<Answer>{
                new Answer("Atomböbchen",false),
                new Answer("Eselchen",false),
                new Answer("Entchen",true),
                new Answer("Otten",false)
            };
            Quizelement question4 = new Quizelement("Alle meine ... schwimmen auf dem See", answers4);
            allQuestions.Add(question4);
        }

    }
}
