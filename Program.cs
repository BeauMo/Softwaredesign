using System;

namespace Softwaredesign
{
    class Program
    {
        static void Main(int[] args)
        {
            if( args[0] < 0 && args[0] > 999){
                Console.Write("Error");
            }
            String sNumber = args[0].ToString();
            int number = Convert.ToInt32(sNumber[0]);
        }
    }
}
