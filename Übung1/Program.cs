using System;
using System.Collections.Generic;
namespace Übung1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> test = new List<string>{"üch@provider.com", "test@test.de", "hans.flm@tt-ii.com", "testemail@tester.test.de"};

            foreach (string mailaddress in test)
            {
                if (IsEmailAddress(mailaddress))
                    Console.WriteLine("TEST PASSED: " + mailaddress + " korrekt als Email-Adresse erkannt");
                else
                    Console.WriteLine("TEST FAILED: " + mailaddress + " nicht als Email-Adresse erkannt, obwohl korrekt.");

            }
        }

        public static bool IsEmailAddress(string emailAddress)
        {
            int iAt = emailAddress.IndexOf('@');
            int iDot = emailAddress.LastIndexOf('.');
            return (iAt > 0 && iDot > iAt);
        }
    }
}
