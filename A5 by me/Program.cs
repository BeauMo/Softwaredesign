using System;
using System.Text;

namespace A5_by_me
{
    class Program
    {
        static StringBuilder wordsBackwardsSB = new StringBuilder();
        static void Main(string[] args)
        {
            string sentence = "Die Maus frisst Käse";
            string[] words = sentence.Split(" ");

            Console.WriteLine(sentence);
            Console.WriteLine(backwardsPerLetter(sentence));
            backwardsPerWord(words);
            Console.WriteLine(wordsBackwardsSB);
        }

        static string backwardsPerLetter(string stringToTurn){
            StringBuilder letters = new StringBuilder();
            for(int i = stringToTurn.Length-1; i >= 0; i--){
                letters.Append(stringToTurn[i]);
            }
            return letters.ToString();
        }

        static void backwardsPerWord(string[] stringToExchange){
            StringBuilder words = new StringBuilder();
            for(int i = stringToExchange.Length-1; i >= 0; i--){
                words.Append(stringToExchange[i] + " ");
                wordsBackwardsSB.Append(backwardsPerLetter(stringToExchange[stringToExchange.Length-1-i] + " "));
            }
            wordsBackwardsSB.Remove(0,1);
            Console.WriteLine(words.ToString());
        }
    }
}
