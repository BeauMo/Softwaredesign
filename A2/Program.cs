using System;

namespace A2
{
    class Program
    {
        static void Main(string[] args)
        {
            //vars();
            //arrays();
            //strings();
            //strings2();
            //switchcase();
            //schleifen1();
            //schleifen2();
            //schleifen3();
            Console.WriteLine(decimalToHexal(122));
        }

        static int decimalToHexal(int dec)
        {
            int result = 0;
            int factor = 1;
            while (dec != 0)
            {
                int digit = dec % 6;
                dec /= 6;
                result += factor * digit;
                factor *= 10;
            }
            return result;
        }

        static void vars()
        {
            var i = 12;
            var pi = Math.PI;
            var salute = "Hi";
            var shoort = 20000000000;
            var flooat = 4.1111F;
            var doouble = 0.12345;

            Console.WriteLine(i.GetTypeCode());
            Console.WriteLine(pi.GetTypeCode());
            Console.WriteLine(salute.GetTypeCode());
            Console.WriteLine(shoort.GetTypeCode());
            Console.WriteLine(flooat.GetTypeCode());
            Console.WriteLine(doouble.GetTypeCode());
        }

        static void arrays()
        {
            int[] ia = { 1, 0, 2, 9, 3, 8, 4, 7, 5, 6 };
            int ergebnis = ia[2] * ia[8] + ia[4];

            Console.WriteLine(ergebnis);

            double[] da = { Math.PI, 5, 3, 4, 6 };

            Console.WriteLine(da.Length);
        }

        static void strings()
        {
            //string meinString = "Dies ist ein String";

            string a = "Dies ist ";
            string b = "ein String";
            string c = a + b;

            //Console.WriteLine(meinString);
            //Console.WriteLine(c);

            string d = "eins";
            string e = "zwei";
            string f = "eins";
            bool d_equals_e = (d == e);
            bool d_equals_f = (d == f);

            Console.WriteLine(d_equals_e);
            Console.WriteLine(d_equals_f);
        }

        static void strings2()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            if (a >= 3 && b == 6)
            {
                Console.WriteLine("Du hast gewonnen!");
            }
            else
            {
                Console.WriteLine("Leider verloren");
            }
        }

        static void switchcase()
        {
            int i = int.Parse(Console.ReadLine());
            switch (i)
            {
                case 1:
                    Console.WriteLine("Du hast EINS eingegeben");
                    break;
                case 2:
                    Console.WriteLine("ZWEI war Deine Wahl");
                    break;
                case 3:
                    Console.WriteLine("Du tipptest eine DREI");
                    break;
                case 9:
                    Console.WriteLine("9");
                    break;
                default:
                    Console.WriteLine("Die Zahl " + i + " kenne ich nicht");
                    break;
            }

            string s = Console.ReadLine();
            switch (s)
            {
                case "Hi":
                    Console.WriteLine("Du hast HI eingegeben");
                    break;
                case "Hey":
                    Console.WriteLine("Hey war Deine Wahl");
                    break;
                case "Hallo":
                    Console.WriteLine("Du tipptest Hallo");
                    break;
                case "GG":
                    Console.WriteLine("GG war dein Wort");
                    break;
                default:
                    Console.WriteLine("Das Wort " + s + " kenne ich nicht");
                    break;
            }

        }

        static void ifelse()
        {
            string s = Console.ReadLine();

            if (s == "Hi")
            {
                Console.WriteLine("Du hast Hi eingegeben.");

            }
            else if (s == "Hey")
            {
                Console.WriteLine("Hey war deine Wahl");
            }
            else if (s == "Hallo")
            {
                Console.WriteLine("Du tipptest Hallo");
            }
            else
            {
                Console.WriteLine("Das Wort " + s + " kenne ich leider nicht.");
            }


        }
        static void schleifen1()
        {
            int i = 0;
            while (i < 10)
            {
                i++;
                Console.WriteLine(i);
            }


        }

        static void schleifen2()
        {
            string[] someStrings =
            {
                "Hier",
                "sehen",
                "wir",
                "einen",
                "Array",
                "von",
                "Strings"
            };
            /* for(int i = 0; i <5 ; i++)
            {
                Console.WriteLine(someStrings[i]);
            } */

            int i = 0;
            while (i < someStrings.Length)
            {
                Console.WriteLine(someStrings[i]);
                i++;

            }
        }
        static void schleifen3()
        {

            string[] someStrings =
            {
                "Hier",
                "sehen",
                "wir",
                "einen",
                "Array",
                "von",
                "Strings"
            };


            int i = 0;
            do
            {
                Console.WriteLine(someStrings[i]);
                i++;
            } while (i < someStrings.Length);

            int g = 0;
            while (true)
            {
                Console.WriteLine(someStrings[g]);
                if (g > someStrings.Length)
                    break;
                g++;

            }
        }
    }
}
