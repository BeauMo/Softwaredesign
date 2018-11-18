using System;
using System.Text;

namespace A5
{
    class Program
    {
        static void Main(string[] args)
        {
            String input = "Die Maus frisst Käse";

            Console.WriteLine(input);
            Console.WriteLine(reverseString(input));
            Console.WriteLine(reverseSentence(input));
        }

        static String reverseString(String input){
            char[] reverseInput = input.ToCharArray();
            Array.Reverse(reverseInput);
            String returnString = new String(reverseInput);
            return returnString;
        }

        static String reverseSentence(String input){
            string[] splittedInput = input.Split(" ");
            Array.Reverse(splittedInput);
            String reversedSentence = String.Join(separator: " ", value: splittedInput);
            return reversedSentence;
        }

        static String reverseWord(String input){
            string[] inputArray = input.Split(" ");
            StringBuilder reversedWord = null;

            for(int i = 0; i < inputArray.Length; i++){
                reversedWord.Append(Reverse(inputArray[i]));
                reversedWord.Append(" ");
            }
            return reversedWord.ToString();
        }
    }
}
