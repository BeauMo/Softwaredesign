using System;

namespace A3
{
    class Program
    {
        static void Main(string[] args)
        {
             {
                int result = 0;
                result = OtherToDecimal(Convert.ToInt32(args[0]), Convert.ToInt32(args[1]));
                result = DecimalToOther(result, Convert.ToInt32(args[2]));
                Console.WriteLine(result);
            }
        }

        static int DecimalToOther(int dec, int system)
        {
            int result = 0;
            int factor = 1;
            while (dec != 0)
            {
                int digit = dec % system;
                dec /= system;
                result += factor * digit;
                factor *= 10;
            }
            Console.WriteLine("DecimalToOther: " + result);
            return result;
        }

        static int OtherToDecimal(int other, int system)
        {
            int result = 0;
            int factor = 1;
            while (other != 0)
            {
                int digit = other % 10;
                other /= 10;
                result += factor * digit;
                factor *= system;
            }
            Console.WriteLine("OtherToDecimal: " + result);
            return result;
        }
    }
}