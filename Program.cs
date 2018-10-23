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
            String romanNumber = "";
            int save = 0;
            int zahlSave = zahl;

            if( zahl < 0 && zahl > 999){
                Console.Write("Error");
            }
            String sNumber = args[0].ToString();
            int number = Convert.ToInt32(sNumber[0]);
            
            if(zahl >= 100){
                save = zahl%100;
                zahlSave = (zahlSave - save)/100;
                romanNumber = romanNumber + hunderter[zahlSave].ToString();
            }
            if(zahl >= 10){
                int a = save%10;
                zahlSave = (save-a)/10;
                romanNumber = romanNumber + zehner[zahlSave].ToString();
                zahlSave = 0;
            }
            if(zahl >= 0){
                save = zahl%10;
                romanNumber = romanNumber + einer[save].ToString();
            }

            Console.Write(romanNumber);
        }
    }
}
