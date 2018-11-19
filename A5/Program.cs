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
            Console.WriteLine(reverseWord(input));
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

        public static String reverseWord ( String input ){

            string [] inputArray = input . Split ( ' ' ) ;
            string reversedWords = "" ;
            string collectedLetters = "" ;
            
            for ( int i = 0 ; i < inputArray .Length ; i ++ )
            {
            string temporaryString = inputArray [i ] ;
            char [] temporaryArray = temporaryString . ToCharArray () ;
            Array . Reverse (temporaryArray ) ;
            collectedLetters = String . Join ( "" , temporaryArray ) ;
            reversedWords += collectedLetters + " " ;
            }
            return reversedWords ;
        }
    }
}
