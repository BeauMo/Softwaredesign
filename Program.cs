using System;

namespace Softwaredesign
{
    class Program
    {
        static void Main(string[] args)
        {
            int zahl = Convert.ToInt32(args[0]);
            String[] einer = {"","I","II","III","IV","V","VI","VII","VIII","IX"}; 
            String[] zehner = {"","X","XX","XXX","XL","L","LX","LXX","LXXX","XC"};
            String[] hunderter = {"","C","CC","CCC","CD","D","DC","DCC","DCCC","CM"};
            Array[] arrays = {einer,zehner,hunderter};
            String romanNumber = "";
            int i;
            int mod = 10;

            if( zahl < 0 && zahl > 999){
                Console.Write("Error");
            }
            String sNumber = args[0].ToString();
            int number = Convert.ToInt32(sNumber[0]);

            for(int a = 0; a < sNumber.Length; a++){
                i = mod%zahl;
                romanNumber = romanNumber + einer[i].ToString();
                i=i+10;
            }
            Console.Write(romanNumber);
        }
    }
}
