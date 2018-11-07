using System;

namespace Softwaredesign
{
    class Program
    {
        static void Main(string[] args)
        {
            String romanNumber = "";

            //int zahl = Convert.ToInt32(args[0]);
            int zahl = 10;
            String[] einer = {"","I","II","III","IV","V","VI","VII","VIII","IX"}; 
            String[] zehner = {"","X","XX","XXX","XL","L","LX","LXX","LXXX","XC"};
            String[] hunderter = {"","C","CC","CCC","CD","D","DC","DCC","DCCC","CM"};

            int intEiner = zahl%10;
            int intZehner = ((zahl-intEiner)%100)/10;
            int intHunderter = ((zahl-intEiner-intZehner)%100)/100;

            if( zahl < 0 && zahl > 999){
                Console.Write("Error");
            }
            
            if(zahl >= 100){
                romanNumber = romanNumber + hunderter[intHunderter].ToString();
            }
            if(zahl >= 10){
                romanNumber = romanNumber + zehner[intZehner].ToString();
            }
            if(zahl >= 0){
                romanNumber = romanNumber + einer[intEiner].ToString();
            }

            Console.Write(romanNumber);
        }
    }
}

